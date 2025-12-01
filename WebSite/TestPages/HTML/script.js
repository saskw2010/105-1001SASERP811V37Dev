async function verifyAndCopyKey(button) {
    const apiKeyElement = button.parentElement;
    const actualKey = apiKeyElement.dataset.key;
    const originalButtonText = button.textContent;

    // Prompt user for password
    const password = prompt("Enter password to reveal and copy the key:");

    if (password) {
        try {
            // Call server to verify password
            const response = await fetch('skydatacontroller.ashx?action=verifypassword&password=' + encodeURIComponent(password));
            
            if (!response.ok) {
                throw new Error('Network response was not ok');
            }

            const result = await response.text();

            if (result === "Success") {
                // Password is correct, reveal the key and copy it
                apiKeyElement.childNodes[0].nodeValue = actualKey;
                const textToCopy = actualKey;

                navigator.clipboard.writeText(textToCopy).then(() => {
                    button.textContent = 'Copied!';
                    button.style.backgroundColor = '#28a745';

                    setTimeout(() => {
                        apiKeyElement.childNodes[0].nodeValue = '******************************************';
                        button.textContent = originalButtonText;
                        button.style.backgroundColor = ''; 
                    }, 3000);
                }).catch(err => {
                    console.error('Failed to copy text: ', err);
                    button.textContent = 'Failed to copy';
                    button.style.backgroundColor = '#dc3545';
                    setTimeout(() => {
                        apiKeyElement.childNodes[0].nodeValue = '******************************************';
                        button.textContent = originalButtonText;
                        button.style.backgroundColor = '';
                    }, 3000);
                });
            } else {
                // Incorrect password
                alert("Incorrect password!");
                button.textContent = 'Access Denied';
                button.style.backgroundColor = '#dc3545';
                setTimeout(() => {
                    button.textContent = originalButtonText;
                    button.style.backgroundColor = '';
                }, 2000);
            }
        } catch (error) {
            console.error('Error verifying password:', error);
            alert("Error verifying password. Please try again.");
            button.textContent = 'Error';
            button.style.backgroundColor = '#dc3545';
            setTimeout(() => {
                button.textContent = originalButtonText;
                button.style.backgroundColor = '';
            }, 2000);
        }
    } else {
        // User cancelled the prompt
        console.log("Password prompt cancelled.");
    }
}

// Function to set the initial password (call this once)
async function setInitialPassword() {
    const password = "WytSky@2021"; // Your secure password here
    try {
        const response = await fetch('skydatacontroller.ashx?action=setpassword&password=' + encodeURIComponent(password));
        
        if (!response.ok) {
            throw new Error('Network response was not ok');
        }

        const result = await response.text();
        console.log("Password set result:", result);
    } catch (error) {
        console.error('Error setting password:', error);
    }
}

// Call this once to set the password
// setInitialPassword();
