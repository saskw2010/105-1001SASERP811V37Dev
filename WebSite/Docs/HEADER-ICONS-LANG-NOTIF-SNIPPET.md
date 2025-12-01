# Header Icons (Language + Notifications) – Deferred Snippet

This snippet was previously injected by JavaScript in `Main.master` to create and position the language and notification buttons in the MembershipBar. We removed it from runtime, and keep it here for future reuse.

## JavaScript Snippet

```javascript
// Create or find the header icon group in MembershipBar
let group = membership.querySelector('.header-icon-group');
if (!group) {
    group = document.createElement('span');
    group.className = 'header-icon-group center';
    group.style.display = 'inline-flex';
    group.style.gap = '.25rem';
}

// Language button (create if missing)
let btnLang = document.getElementById('languageToggleBtn');
if (!btnLang) {
    btnLang = document.createElement('button');
    btnLang.id = 'languageToggleBtn';
    btnLang.className = 'header-icon-btn';
    btnLang.type = 'button';
    btnLang.title = 'اللغة';
    btnLang.onclick = function() { if (typeof toggleMembershipLanguage === 'function') toggleMembershipLanguage(); };
    btnLang.innerHTML = '<i class="fas fa-globe"></i>';
}
if (btnLang && !group.contains(btnLang)) group.appendChild(btnLang);

// Notifications button (create if missing)
let notifBtn = membership.querySelector('#headerNotifBtn');
if (!notifBtn) {
    notifBtn = document.createElement('button');
    notifBtn.id = 'headerNotifBtn';
    notifBtn.className = 'header-icon-btn';
    notifBtn.type = 'button';
    notifBtn.title = 'Notifications';
    notifBtn.innerHTML = '<i class="fas fa-bell"></i>';
}
if (notifBtn && !group.contains(notifBtn)) group.appendChild(notifBtn);

// Notifications dropdown wiring
let notifDrop = document.getElementById('headerNotifDropdown');
if (!notifDrop) {
    notifDrop = document.createElement('div');
    notifDrop.id = 'headerNotifDropdown';
    notifDrop.className = 'header-dropdown';
    notifDrop.innerHTML = '<div class="dropdown-title">Notifications</div>' +
        '<div class="dropdown-item">No new notifications</div>';
    document.body.appendChild(notifDrop);
}

function closeDrops(){ notifDrop.classList.remove('open'); }
notifBtn.addEventListener('click', function(e){
    e.stopPropagation();
    const isOpen = notifDrop.classList.contains('open');
    closeDrops();
    if (!isOpen) notifDrop.classList.add('open');
});
document.addEventListener('click', closeDrops);
window.addEventListener('resize', closeDrops);

// Insert the group next to system-brand inside membership-content
const membershipContent = membership.querySelector('.membership-content');
const systemBrand = membership.querySelector('.system-brand, .brand, .logo');
if (membershipContent && systemBrand) {
    systemBrand.insertAdjacentElement('afterend', group);
} else if (membershipContent) {
    membershipContent.insertBefore(group, membershipContent.firstChild);
} else {
    const contentDiv = document.createElement('div');
    contentDiv.className = 'membership-content';
    contentDiv.style.display = 'flex';
    contentDiv.style.alignItems = 'center';
    contentDiv.style.justifyContent = 'space-between';
    while (membership.firstChild) contentDiv.appendChild(membership.firstChild);
    contentDiv.appendChild(group);
    membership.appendChild(contentDiv);
}
```

## Notes
- Keep the `toggleMembershipLanguage()` function available if you reuse the language button.
- This snippet expects `membership` to be the MembershipBar root: `document.getElementById('Membership_Login') || document.querySelector('.MembershipBar')`.
