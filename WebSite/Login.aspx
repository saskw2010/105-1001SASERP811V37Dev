<%@ Page Language="VB" AutoEventWireup="true" CodeFile="Login.aspx.vb" Inherits="SKY365.Login" %>

<!DOCTYPE html>
<html lang="ar" dir="ltr">
<head runat="server">
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>تسجيل الدخول - SKY365 ERP</title>
    <!-- External Resources (CDN - Optional, can work offline without them) -->
    <link href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0/css/all.min.css" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css2?family=Cairo:wght@300;400;500;600;700&display=swap" rel="stylesheet">
    
    <!-- Note: All CSS and JavaScript are inline in this page for maximum compatibility -->
    <!-- No external files required except CDN resources above -->
    
    <style>
        :root {
            /* AI Revolution Color Palette */
            --primary-color: #0b6495;
            --secondary-color: #1d4ed8;
            --accent-color: #3b82f6;
            --ai-cyan: #60a5fa;
            --ai-purple: #2563eb;
            --ai-pink: #1e40af;
            --ai-violet: #3730a3;
            --ai-blue: #1d4ed8;
            --neural-green: #10b981;
            --quantum-orange: #f59e0b;
            --text-color: #1e293b;
            --light-text: #64748b;
            --dark-text: #0f172a;
            --light-bg: #f8fafc;
            --white: #ffffff;
            --danger: #ef4444;
            --success: #10b981;
            --border-color: rgba(37, 99, 235, 0.2);
            --shadow: 0 8px 32px rgba(37,99,235,0.15);
            --transition: all 0.4s cubic-bezier(.4,0,.2,1);
            --glass: rgba(255,255,255,0.1);
            
            /* Beautiful Blue Gradients */
            --ai-gradient-1: linear-gradient(135deg, #2563eb 0%, #1d4ed8 50%, #1e40af 100%);
            --ai-gradient-2: linear-gradient(120deg, #60a5fa 0%, #2563eb 100%);
            --ai-gradient-3: linear-gradient(45deg, #3b82f6 0%, #2563eb 50%, #1d4ed8 100%);
            --neural-gradient: linear-gradient(90deg, #60a5fa 0%, #3b82f6 33%, #2563eb 66%, #1d4ed8 100%);
        }
        
        /* Responsive status removed for Live compatibility */
        
        body {
            min-height: 100vh;
            background: var(--ai-gradient-1);
            background-size: cover;
            background-position: center;
            background-repeat: no-repeat;
            background-attachment: fixed;
            position: relative;
            /* Fallback fonts if Google Fonts not available */
            font-family: 'Cairo', 'Segoe UI', Tahoma, Arial, sans-serif;
            overflow-x: hidden;
        }
        body::before {
            content: '';
            position: fixed;
            top: 0;
            left: 0;
            width: 100%;
            height: 100%;
            background: radial-gradient(circle at 30% 70%, rgba(37,99,235,0.2) 0%, transparent 50%),
                        radial-gradient(circle at 70% 30%, rgba(29,78,216,0.15) 0%, transparent 50%),
                        linear-gradient(135deg, rgba(59,130,246,0.1) 0%, rgba(37,99,235,0.05) 100%);
            pointer-events: none;
            z-index: 0;
            animation: aiPulse 8s ease-in-out infinite;
        }
        
        @keyframes aiPulse {
            0%, 100% { opacity: 0.3; }
            50% { opacity: 0.6; }
        }
        
        .container-fluid {
            min-height: 100vh;
            display: flex;
            align-items: center;
            justify-content: center;
            padding: 0;
            position: relative;
            z-index: 1;
        }
        
        .row {
            display: flex;
            flex-direction: row;
            flex-wrap: wrap;
            width: 100%;
            max-width: 1200px;
            justify-content: center;
            align-items: flex-start;
            padding: 2rem;
            margin: 0 auto;
            gap: 2rem;
        }

        .login-container {
            flex: 0 0 auto;
            width: 100%;
            max-width: 450px;
            display: flex;
            align-items: center;
            justify-content: center;
        }
        
        .news-updates-container {
            flex: 0 0 auto;
            width: 100%;
            max-width: 500px;
        }
        
        /* Responsive Layout */
        @media (min-width: 1024px) {
            .row {
                flex-direction: row;
                align-items: flex-start;
            }
            
            .login-container {
                max-width: 450px;
            }
            
            .news-updates-container {
                max-width: 500px;
                margin-top: 0;
            }
        }
        
        @media (max-width: 1023px) {
            .row {
                flex-direction: column;
                align-items: center;
                gap: 2rem;
            }
            
            .login-container {
                max-width: 500px;
            }
            
            .news-updates-container {
                max-width: 500px;
            }
        }

        .card-glass {
            background: linear-gradient(135deg, rgba(255,255,255,0.95) 0%, rgba(255,255,255,0.85) 100%);
            border-radius: 28px;
            box-shadow: 0 25px 80px 0 rgba(0,212,255,0.15), 
                        0 8px 32px 0 rgba(124,58,237,0.1),
                        inset 0 1px 0 rgba(255,255,255,0.6);
            backdrop-filter: blur(25px);
            border: 1px solid;
            border-image: var(--neural-gradient) 1;
            overflow: hidden;
            margin: 0;
            width: 100%;
            min-height: 500px;
            display: flex;
            flex-direction: column;
            justify-content: center;
            align-items: center;
            position: relative;
            z-index: 2;
            animation: fadeIn 1.2s cubic-bezier(.4,0,.2,1);
            transition: all 0.4s cubic-bezier(.4,0,.2,1);
        }

        .card-glass::before {
            content: '';
            position: absolute;
            top: 0;
            left: 0;
            right: 0;
            height: 1px;
            background: var(--neural-gradient);
            animation: neuralScan 3s linear infinite;
        }

        .card-glass:hover {
            transform: translateY(-8px) scale(1.02);
            box-shadow: 0 35px 100px 0 rgba(0,212,255,0.25), 
                        0 12px 48px 0 rgba(124,58,237,0.2),
                        inset 0 1px 0 rgba(255,255,255,0.8);
            border-image: linear-gradient(135deg, #00d4ff 0%, #ff006e 100%) 1;
        }

        @keyframes neuralScan {
            0% { transform: translateX(-100%); }
            100% { transform: translateX(100%); }
        }

        /* Responsive Design for Single Card */
        @media (max-width: 767px) {
            .row {
                padding: 1rem;
            }
            .card-glass {
                min-height: 400px;
                border-radius: 16px;
            }
        }

        @media (max-width: 576px) {
            .row {
                padding: 0.5rem;
            }
            .card-glass {
                min-height: 350px;
                border-radius: 12px;
                margin: 0 0.5rem;
            }
        }

        .divider {
            display: flex;
            align-items: center;
            margin: 1.5rem 0;
        }

        .divider::before,
        .divider::after {
            content: '';
            flex: 1;
            border-bottom: 2px solid var(--primary-color);
            opacity: 0.5;
            animation: dividerPulse 2s infinite alternate;
        }

        @keyframes dividerPulse {
            0% {opacity: 0.5;}
            100% {opacity: 1;}
        }

        .divider-text {
            padding: 0 1rem;
            color: var(--primary-color);
            font-weight: 700;
            font-size: 1rem;
            letter-spacing: 1px;
            text-shadow: 0 2px 8px rgba(37,99,235,0.22);
        }
        
        .login-form-side {
            width: 100%;
            max-width: 500px;
            padding: 2.5rem;
        }
        
        .btn-google {
            background: linear-gradient(90deg, #fff 0%, #e3f0fc 100%);
            color: #DB4437;
            border: 2px solid #DB4437;
            display: flex;
            align-items: center;
            justify-content: center;
            gap: 0.5rem;
            text-decoration: none;
            font-weight: 700;
            box-shadow: 0 2px 8px #db443722;
            transition: var(--transition);
            position: relative;
            overflow: hidden;
            margin-top: 10px;
            width: 100%;
        }

        .btn-google i {
            color: #DB4437;
            font-size: 1.2rem;
            animation: pulse 2s infinite alternate;
        }

        .btn-google:hover {
            background: linear-gradient(90deg, #f9fafb 0%, #fff 100%);
            border-color: #DB4437;
            box-shadow: 0 8px 24px #db443744;
            color: #DB4437;
            transform: scale(1.04);
        }

        @keyframes pulse {
            0% {transform: scale(1);}
            100% {transform: scale(1.08);}
        }
        
        .brand-text {
            font-size: 1.5rem;
            font-weight: 700;
            background: var(--neural-gradient);
            -webkit-background-clip: text;
            -webkit-text-fill-color: transparent;
            background-clip: text;
            margin-bottom: 1.5rem;
            line-height: 1.4;
            letter-spacing: 1px;
            text-align: center;
            animation: aiGlow 2s ease-in-out infinite alternate;
            position: relative;
        }
        
        .brand-text::after {
            content: '';
            position: absolute;
            bottom: -5px;
            left: 50%;
            transform: translateX(-50%);
            width: 60px;
            height: 2px;
            background: var(--ai-gradient-2);
            border-radius: 1px;
            animation: expandLine 1.5s ease-in-out infinite alternate;
        }
        
        .brand-text span {
            background: linear-gradient(135deg, #2563eb 0%, #1d4ed8 100%);
            -webkit-background-clip: text;
            -webkit-text-fill-color: transparent;
            background-clip: text;
            font-weight: 800;
            text-shadow: 0 0 30px rgba(37,99,235,0.5);
        }

        @keyframes aiGlow {
            0% { filter: brightness(1) saturate(1); }
            100% { filter: brightness(1.2) saturate(1.3); }
        }

        @keyframes expandLine {
            0% { width: 60px; }
            100% { width: 120px; }
        }
        
        .form-group {
            margin-bottom: 1.2rem;
            position: relative;
            text-align: left;
        }
        
        .form-control {
            width: 100%;
            padding: 1rem 1.2rem;
            font-size: 1rem;
            border: 2px solid transparent;
            border-radius: 16px;
            transition: var(--transition);
            background: linear-gradient(135deg, rgba(255,255,255,0.9) 0%, rgba(248,250,252,0.8) 100%);
            color: var(--dark-text);
            font-weight: 500;
            box-shadow: inset 0 2px 8px rgba(37,99,235,0.1),
                        0 4px 16px rgba(0,0,0,0.05);
            outline: none;
            position: relative;
            z-index: 1;
        }

        .form-control::placeholder {
            color: var(--light-text);
            opacity: 0.7;
        }
        
        .form-control:focus {
            border: 2px solid;
            border-image: var(--ai-gradient-2) 1;
            box-shadow: 0 0 0 4px rgba(37,99,235,0.1),
                        inset 0 2px 8px rgba(37,99,235,0.15),
                        0 8px 32px rgba(29,78,216,0.15);
            background: linear-gradient(135deg, rgba(255,255,255,0.95) 0%, rgba(248,250,252,0.9) 100%);
            animation: none;
            transform: translateY(-2px);
        }
        
        .form-label {
            position: absolute;
            top: 1rem;
            left: 1.2rem;
            pointer-events: none;
            transition: var(--transition);
            background: var(--ai-gradient-2);
            -webkit-background-clip: text;
            -webkit-text-fill-color: transparent;
            background-clip: text;
            font-size: 1rem;
            font-weight: 600;
            z-index: 2;
        }
        
        .form-control:focus + .form-label,
        .form-control:not(:placeholder-shown) + .form-label {
            transform: translateY(-2.5rem) scale(0.85);
            font-size: 0.85rem;
            background: var(--neural-gradient);
            -webkit-background-clip: text;
            -webkit-text-fill-color: transparent;
            background-clip: text;
            padding: 0 0.5rem;
            font-weight: 700;
            border-radius: 8px;
            backdrop-filter: blur(10px);
        }
        
        .btn {
            display: inline-block;
            font-weight: 600;
            text-align: center;
            white-space: nowrap;
            vertical-align: middle;
            user-select: none;
            border: 2px solid transparent;
            padding: 0.8rem 1.5rem;
            font-size: 1rem;
            line-height: 1.4;
            border-radius: 14px;
            transition: var(--transition);
            cursor: pointer;
            width: 100%;
            text-transform: none;
            box-shadow: 0 2px 12px #3a8dde22;
            background: linear-gradient(90deg, #f9fafb 0%, #e3f0fc 100%);
            color: var(--primary-color);
        }
        .btn-primary {
            color: #fff;
            background: var(--ai-gradient-2);
            border: 2px solid transparent;
            background-clip: padding-box;
            font-weight: 700;
            letter-spacing: 1px;
            text-transform: uppercase;
            box-shadow: 0 8px 32px rgba(37,99,235,0.3),
                        inset 0 1px 0 rgba(255,255,255,0.2);
            position: relative;
            overflow: hidden;
            animation: aiButtonPulse 2s ease-in-out infinite;
        }

        .btn-primary::before {
            content: '';
            position: absolute;
            top: 0;
            left: -100%;
            width: 100%;
            height: 100%;
            background: linear-gradient(90deg, transparent, rgba(255,255,255,0.4), transparent);
            transition: left 0.8s cubic-bezier(.4,0,.2,1);
        }

        .btn-primary:hover::before {
            left: 100%;
        }

        .btn-primary:hover {
            background: var(--neural-gradient);
            transform: translateY(-3px) scale(1.05);
            box-shadow: 0 15px 50px rgba(37,99,235,0.4),
                        0 8px 32px rgba(29,78,216,0.2),
                        inset 0 1px 0 rgba(255,255,255,0.3);
        }

        @keyframes aiButtonPulse {
            0%, 100% { box-shadow: 0 8px 32px rgba(37,99,235,0.3), inset 0 1px 0 rgba(255,255,255,0.2); }
            50% { box-shadow: 0 12px 48px rgba(37,99,235,0.5), inset 0 1px 0 rgba(255,255,255,0.3); }
        }
        .btn-google {
            background: linear-gradient(135deg, rgba(255,255,255,0.95) 0%, rgba(248,250,252,0.9) 100%);
            color: #DB4437;
            border: 2px solid;
            border-image: linear-gradient(135deg, #DB4437 0%, #2563eb 100%) 1;
            display: flex;
            align-items: center;
            justify-content: center;
            gap: 0.5rem;
            text-decoration: none;
            font-weight: 700;
            box-shadow: 0 4px 16px rgba(219,68,55,0.2),
                        inset 0 1px 0 rgba(255,255,255,0.6);
            transition: var(--transition);
            position: relative;
            overflow: hidden;
            margin-top: 10px;
            width: 100%;
        }
        .btn-google:hover {
            background: linear-gradient(135deg, rgba(255,255,255,1) 0%, rgba(248,250,252,0.95) 100%);
            border-image: linear-gradient(135deg, #2563eb 0%, #1d4ed8 100%) 1;
            box-shadow: 0 8px 32px rgba(219,68,55,0.3),
                        0 4px 16px rgba(37,99,235,0.2),
                        inset 0 1px 0 rgba(255,255,255,0.8);
            color: #DB4437;
            transform: translateY(-2px) scale(1.03);
        }
        .btn-link {
            background: none;
            border: none;
            color: var(--accent-color);
            text-decoration: none;
            padding: 0;
            font-size: 0.95rem;
            cursor: pointer;
            text-align: right;
            font-weight: 600;
            border-radius: 14px;
            transition: var(--transition);
            margin-top: 10px;
            box-shadow: 0 2px 8px #3a8dde22;
        }
        .btn-link:hover {
            text-decoration: underline;
            color: var(--primary-color);
            background: #e3f0fc;
        }
        
        /* Updates Button Styling */
        .btn-updates {
            width: 100%;
            padding: 0.8rem 1.5rem;
            background: linear-gradient(135deg, #667eea 0%, #764ba2 100%);
            color: white;
            border: none;
            border-radius: 14px;
            font-size: 0.95rem;
            font-weight: 600;
            cursor: pointer;
            transition: all 0.4s cubic-bezier(.4,0,.2,1);
            display: flex;
            align-items: center;
            justify-content: center;
            gap: 0.5rem;
            box-shadow: 0 4px 16px rgba(102, 126, 234, 0.3);
            position: relative;
            overflow: hidden;
        }
        
        .btn-updates::before {
            content: '';
            position: absolute;
            top: 0;
            left: -100%;
            width: 100%;
            height: 100%;
            background: linear-gradient(90deg, transparent, rgba(255,255,255,0.3), transparent);
            transition: left 0.6s;
        }
        
        .btn-updates:hover::before {
            left: 100%;
        }
        
        .btn-updates:hover {
            transform: translateY(-2px);
            box-shadow: 0 8px 24px rgba(102, 126, 234, 0.4);
            background: linear-gradient(135deg, #764ba2 0%, #667eea 100%);
        }
        
        .btn-updates .arrow-icon {
            font-size: 0.8rem;
            animation: bounceArrow 2s ease-in-out infinite;
        }
        
        @keyframes bounceArrow {
            0%, 100% { transform: translateY(0); }
            50% { transform: translateY(4px); }
        }
        
        /* Diagnostic Button Styling */
        #btnDiagnose {
            color: #6b7280;
            font-size: 0.85rem;
            padding: 0.5rem;
            transition: all 0.3s ease;
        }
        
        #btnDiagnose:hover {
            color: var(--primary-color);
            background: rgba(11, 100, 149, 0.05);
            transform: scale(1.02);
        }
        
        .text-end {
            text-align: right;
        }
        
        .alert {
            padding: 1rem 1.2rem;
            margin-bottom: 1.2rem;
            border-radius: 8px;
            font-weight: 600;
            border-left: 4px solid;
        }
        
        .alert-danger {
            background-color: rgba(220, 38, 38, 0.1);
            color: var(--danger);
            border-left-color: var(--danger);
            border: 2px solid rgba(220, 38, 38, 0.2);
        }
        
        .alert-info {
            background-color: rgba(37, 99, 235, 0.1);
            color: var(--accent-color);
            border-left-color: var(--accent-color);
            border: 2px solid rgba(37, 99, 235, 0.2);
        }
        
        .divider {
            display: flex;
            align-items: center;
            margin: 1.5rem 0;
        }
        
        .divider::before,
        .divider::after {
            content: '';
            flex: 1;
            border-bottom: 2px solid var(--border-color);
        }
        
        .divider-text {
            padding: 0 1rem;
            color: var(--light-text);
            font-weight: 600;
            font-size: 0.9rem;
        }
        
        .social-btn i {
            font-size: 1.2rem;
        }
        
        /* Responsive styles - Simplified */
        @media screen and (max-width: 768px) {
            .login-form-side {
                padding: 1.5rem;
            }
            
            .logo {
                max-width: 70px !important;
            }
            
            .brand-text {
                font-size: 1.2rem !important;
            }
        }
        
        @media screen and (max-width: 576px) {
            .login-form-side {
                padding: 1rem;
            }
            
            .logo {
                max-width: 60px !important;
            }
            
            .brand-text {
                font-size: 1rem !important;
                margin-bottom: 0.8rem !important;
            }
        }

        .logo-container {
            width: 100%;
            display: flex;
            flex-direction: column;
            align-items: center;
            justify-content: center;
            margin-bottom: 1rem;
        }

        .logo {
            max-width: 120px !important;
            margin-bottom: 16px;
            box-shadow: 0 0 40px rgba(37,99,235,0.4),
                        0 0 80px rgba(29,78,216,0.2),
                        inset 0 0 20px rgba(255,255,255,0.8);
            border-radius: 50%;
            background: radial-gradient(circle, #ffffff 0%, #f8fafc 100%);
            border: 3px solid;
            border-image: var(--neural-gradient) 1;
            transition: var(--transition);
            animation: logoRotate 10s linear infinite, logoPulse 2s ease-in-out infinite alternate;
        }

        .logo:hover {
            transform: scale(1.15) rotate(15deg);
            box-shadow: 0 0 60px rgba(37,99,235,0.6),
                        0 0 120px rgba(29,78,216,0.4),
                        inset 0 0 30px rgba(255,255,255,1);
        }

        @keyframes logoRotate {
            from { filter: hue-rotate(0deg); }
            to { filter: hue-rotate(360deg); }
        }

        @keyframes logoPulse {
            0% { box-shadow: 0 0 40px rgba(37,99,235,0.4), 0 0 80px rgba(29,78,216,0.2), inset 0 0 20px rgba(255,255,255,0.8); }
            100% { box-shadow: 0 0 60px rgba(37,99,235,0.6), 0 0 100px rgba(29,78,216,0.3), inset 0 0 25px rgba(255,255,255,1); }
        }

        /* Mobile iOS Fix */
        @media (max-width: 768px) {
            .form-control {
                font-size: 16px; /* Prevents zoom on iOS */
            }
        }

        /* Animation Keyframes */
        @keyframes fadeIn {
            from {
                opacity: 0;
                transform: translateY(30px);
            }
            to {
                opacity: 1;
                transform: translateY(0);
            }
        }

        @keyframes inputPulse {
            0% { box-shadow: 0 2px 12px rgba(58,141,222,0.1); }
            100% { box-shadow: 0 2px 16px rgba(58,141,222,0.2); }
        }
        
        /* ========================================
           System Updates & News Section Styles
        ======================================== */
        
        .news-card {
            background: linear-gradient(135deg, rgba(255,255,255,0.95) 0%, rgba(255,255,255,0.9) 100%);
            border-radius: 24px;
            padding: 2rem;
            box-shadow: 0 20px 60px rgba(37,99,235,0.15),
                        0 8px 24px rgba(0,0,0,0.1),
                        inset 0 1px 0 rgba(255,255,255,0.6);
            backdrop-filter: blur(20px);
            border: 1px solid rgba(37,99,235,0.1);
            animation: slideInUp 0.8s cubic-bezier(.4,0,.2,1);
        }
        
        .news-header {
            display: flex;
            align-items: center;
            gap: 1rem;
            margin-bottom: 1.5rem;
            padding-bottom: 1rem;
            border-bottom: 2px solid rgba(37,99,235,0.1);
        }
        
        .news-header i {
            font-size: 1.8rem;
            background: var(--neural-gradient);
            -webkit-background-clip: text;
            -webkit-text-fill-color: transparent;
            background-clip: text;
            animation: pulse 2s ease-in-out infinite;
        }
        
        .news-header h3 {
            margin: 0;
            font-size: 1.3rem;
            font-weight: 700;
            background: var(--ai-gradient-2);
            -webkit-background-clip: text;
            -webkit-text-fill-color: transparent;
            background-clip: text;
        }
        
        .news-items {
            display: flex;
            flex-direction: column;
            gap: 1rem;
        }
        
        .news-item {
            display: flex;
            gap: 1rem;
            padding: 1rem;
            background: linear-gradient(135deg, rgba(248,250,252,0.8) 0%, rgba(255,255,255,0.6) 100%);
            border-radius: 16px;
            border: 1px solid rgba(37,99,235,0.08);
            transition: all 0.4s cubic-bezier(.4,0,.2,1);
            animation: fadeInSlide 0.6s cubic-bezier(.4,0,.2,1) backwards;
            cursor: pointer;
        }
        
        .news-item:hover {
            transform: translateX(-8px) scale(1.02);
            box-shadow: 0 12px 32px rgba(37,99,235,0.15),
                        0 4px 16px rgba(0,0,0,0.08);
            border-color: rgba(37,99,235,0.2);
            background: linear-gradient(135deg, rgba(255,255,255,0.95) 0%, rgba(248,250,252,0.9) 100%);
        }
        
        .news-icon {
            width: 50px;
            height: 50px;
            min-width: 50px;
            border-radius: 12px;
            display: flex;
            align-items: center;
            justify-content: center;
            font-size: 1.5rem;
            transition: all 0.4s cubic-bezier(.4,0,.2,1);
            box-shadow: 0 4px 16px rgba(0,0,0,0.1);
        }
        
        .news-item:hover .news-icon {
            transform: scale(1.1) rotate(5deg);
        }
        
        /* Icon Colors */
        .ai-icon {
            background: linear-gradient(135deg, #667eea 0%, #764ba2 100%);
            color: white;
        }
        
        .analytics-icon {
            background: linear-gradient(135deg, #f093fb 0%, #f5576c 100%);
            color: white;
        }
        
        .mobile-icon {
            background: linear-gradient(135deg, #4facfe 0%, #00f2fe 100%);
            color: white;
        }
        
        .security-icon {
            background: linear-gradient(135deg, #43e97b 0%, #38f9d7 100%);
            color: white;
        }
        
        .cloud-icon {
            background: linear-gradient(135deg, #fa709a 0%, #fee140 100%);
            color: white;
        }
        
        .performance-icon {
            background: linear-gradient(135deg, #30cfd0 0%, #330867 100%);
            color: white;
        }
        
        .news-content {
            flex: 1;
            text-align: right;
        }
        
        .news-content h4 {
            margin: 0 0 0.5rem 0;
            font-size: 1rem;
            font-weight: 700;
            color: var(--dark-text);
            line-height: 1.4;
        }
        
        .news-content p {
            margin: 0;
            font-size: 0.85rem;
            color: var(--light-text);
            line-height: 1.6;
        }
        
        /* Animations */
        @keyframes slideInUp {
            from {
                opacity: 0;
                transform: translateY(40px);
            }
            to {
                opacity: 1;
                transform: translateY(0);
            }
        }
        
        @keyframes fadeInSlide {
            from {
                opacity: 0;
                transform: translateX(30px);
            }
            to {
                opacity: 1;
                transform: translateX(0);
            }
        }
        
        /* Responsive */
        @media (max-width: 768px) {
            .news-updates-container {
                max-width: 100%;
                margin-top: 1.5rem;
            }
            
            .news-card {
                padding: 1.5rem;
                border-radius: 16px;
            }
            
            .news-header h3 {
                font-size: 1.1rem;
            }
            
            .news-icon {
                width: 45px;
                height: 45px;
                min-width: 45px;
                font-size: 1.3rem;
            }
            
            .news-content h4 {
                font-size: 0.95rem;
            }
            
            .news-content p {
                font-size: 0.8rem;
            }
        }
        
        @media (max-width: 576px) {
            .news-card {
                padding: 1rem;
            }
            
            .news-item {
                padding: 0.8rem;
                gap: 0.8rem;
            }
            
            .news-icon {
                width: 40px;
                height: 40px;
                min-width: 40px;
                font-size: 1.2rem;
            }
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" autocomplete="off">
        <div id="LoginControl" class="login-control">
            <div class="container-fluid">
                <div class="row">
                    <!-- Login Form Card - Single Centered Card -->
                    <div class="login-container">
                        <div class="card-glass login-form-side">
                            <div class="logo-container">
                                <img src="../assets/img/logo.png" alt="Logo" class="logo" />
                                <h2 class="brand-text"><span>ai</span> Optimal Enterprise Solutions</h2>
                            </div>
                            
                            <div class="login-form">
                                <!-- Error Message -->
                                <asp:Label ID="lblError" runat="server" CssClass="alert alert-danger" Visible="false" />
                                
                                <!-- Username Input -->
                                <div class="form-group">
                                    <asp:TextBox ID="txtUsername" runat="server" CssClass="form-control" placeholder=" " 
                                        autocomplete="off" required></asp:TextBox>
                                    <label class="form-label" for="txtUsername">اسم المستخدم</label>
                                </div>
                                
                                <!-- Password Input -->
                                <div class="form-group">
                                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="form-control" placeholder=" " 
                                        autocomplete="new-password" required></asp:TextBox>
                                    <label class="form-label" for="txtPassword">كلمة المرور</label>
                                </div>
                                
                                <!-- Login Button -->
                                <div class="text-center mb-3">
                                    <asp:Button ID="btnLogin" runat="server"
    Text="تسجيل الدخول"
    CssClass="btn btn-primary"
    OnClick="btnLogin_Click"
    UseSubmitBehavior="false"
    CausesValidation="false" />
                                </div>
                                
                                <!-- Updates Button -->
                                <div class="text-center mb-3">
                                    <button type="button" id="btnShowUpdates" class="btn-updates">
                                        <i class="fas fa-rocket"></i>
                                        <span>اطّلع على آخر التحديثات</span>
                                        <i class="fas fa-chevron-down arrow-icon"></i>
                                    </button>
                                </div>
                                
                                <!-- Diagnostic Button (للمطورين فقط - يظهر حسب web.config) -->
                                <% If ShowDiagnosticButton Then %>
                                <div class="text-center mb-3">
                                    <asp:Button ID="btnDiagnose" runat="server" Text="🔍 فحص إعدادات المصادقة" 
                                        CssClass="btn btn-link" OnClick="btnDiagnose_Click" CausesValidation="false" 
                                        style="font-size: 0.85rem; text-decoration: underline;" />
                                </div>
                                <% End If %>
                                
                                <!-- Google Login Section (Controlled by web.config) -->
                                <% If IsGoogleLoginEnabled Then %>
                                    <!-- Divider -->
                                    <div class="divider">
                                        <span class="divider-text">أو</span>
                                    </div>
                                    
                                    <!-- Google Login -->
                                    <div class="form-group">
                                        <a href="/api/google/start" class="btn btn-google social-btn">
                                            <i class="fab fa-google"></i> تسجيل الدخول عبر Google
                                        </a>
                                    </div>
                                <% End If %>
                                
                                <!-- Forgot Password -->
                                <div class="form-group text-end">
                                    <asp:Button ID="btnForgotPassword" runat="server" Text="نسيت كلمة المرور؟" CssClass="btn-link" OnClientClick="javascript:location.href='../pages/forget-password.aspx'; return false;" CausesValidation="false" />
                                </div>
                            </div>
                        </div>
                    </div>
                    
                    <!-- System Updates & News Section -->
                    <div class="news-updates-container">
                        <div class="news-card">
                            <div class="news-header">
                                <i class="fas fa-newspaper"></i>
                                <h3>آخر التحديثات والمميزات</h3>
                            </div>
                            
                            <div class="news-items">
                                <!-- News Item 1 - AI Feature -->
                                <div class="news-item" style="animation-delay: 0.1s">
                                    <div class="news-icon ai-icon">
                                        <i class="fas fa-brain"></i>
                                    </div>
                                    <div class="news-content">
                                        <h4>🤖 الذكاء الاصطناعي متاح الآن!</h4>
                                        <p>هل تعلم أن الذكاء الاصطناعي أصبح متوفراً بالنظام؟ يمكنك الآن التحدث مع النظام والحصول على تحليلات ذكية من بياناتك</p>
                                    </div>
                                </div>
                                
                                <!-- News Item 2 - Analytics -->
                                <div class="news-item" style="animation-delay: 0.2s">
                                    <div class="news-icon analytics-icon">
                                        <i class="fas fa-chart-line"></i>
                                    </div>
                                    <div class="news-content">
                                        <h4>📊 تقارير تفاعلية محسّنة</h4>
                                        <p>تقارير ديناميكية مع رسوم بيانية تفاعلية وتصدير متعدد الصيغ (PDF, Excel, Word)</p>
                                    </div>
                                </div>
                                
                                <!-- News Item 3 - Mobile -->
                                <div class="news-item" style="animation-delay: 0.3s">
                                    <div class="news-icon mobile-icon">
                                        <i class="fas fa-mobile-alt"></i>
                                    </div>
                                    <div class="news-content">
                                        <h4>📱 تصميم متجاوب بالكامل</h4>
                                        <p>واجهة محسّنة للهواتف والأجهزة اللوحية - اعمل من أي مكان بكل سهولة</p>
                                    </div>
                                </div>
                                
                                <!-- News Item 4 - Security -->
                                <div class="news-item" style="animation-delay: 0.4s">
                                    <div class="news-icon security-icon">
                                        <i class="fas fa-shield-alt"></i>
                                    </div>
                                    <div class="news-content">
                                        <h4>🔒 أمان محسّن</h4>
                                        <p>تشفير متقدم ومصادقة ثنائية لحماية بياناتك بأعلى معايير الأمان</p>
                                    </div>
                                </div>
                                
                                <!-- News Item 5 - Cloud -->
                                <div class="news-item" style="animation-delay: 0.5s">
                                    <div class="news-icon cloud-icon">
                                        <i class="fas fa-cloud"></i>
                                    </div>
                                    <div class="news-content">
                                        <h4>☁️ النسخ الاحتياطي التلقائي</h4>
                                        <p>بياناتك محمية تلقائياً في السحابة - لا تقلق بشأن فقدان المعلومات</p>
                                    </div>
                                </div>
                                
                                <!-- News Item 6 - Performance -->
                                <div class="news-item" style="animation-delay: 0.6s">
                                    <div class="news-icon performance-icon">
                                        <i class="fas fa-rocket"></i>
                                    </div>
                                    <div class="news-content">
                                        <h4>⚡ أداء فائق السرعة</h4>
                                        <p>تحسينات كبيرة في الأداء - النظام أسرع بـ 3 أضعاف من الإصدار السابق</p>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>

    <script type="text/javascript">
        // Minimal JavaScript - Server-Side Focused Login
        // All validation and logic handled by ASP.NET backend
        document.addEventListener('DOMContentLoaded', function() {
            console.log('✅ Login Page Loaded - Server-Side Authentication Ready');
            
            // Disable password saving and autocomplete
            var form = document.getElementById('form1');
            var usernameField = document.getElementById('<%= txtUsername.ClientID %>');
            var passwordField = document.getElementById('<%= txtPassword.ClientID %>');
            
            if (form) {
                form.setAttribute('autocomplete', 'off');
            }
            
            if (usernameField) {
                usernameField.setAttribute('autocomplete', 'off');
                usernameField.setAttribute('autocapitalize', 'off');
                usernameField.setAttribute('autocorrect', 'off');
            }
            
            if (passwordField) {
                passwordField.setAttribute('autocomplete', 'new-password');
                passwordField.setAttribute('data-form-type', 'other');
                
                // Clear password on page load (security measure)
                passwordField.value = '';
                
                // Prevent password managers from filling
                passwordField.addEventListener('focus', function() {
                    this.setAttribute('readonly', 'readonly');
                    setTimeout(function() {
                        passwordField.removeAttribute('readonly');
                    }, 100);
                });
            }
            
            // Updates Button - Smooth Scroll to News Section
            var btnShowUpdates = document.getElementById('btnShowUpdates');
            if (btnShowUpdates) {
                btnShowUpdates.addEventListener('click', function() {
                    var newsSection = document.querySelector('.news-updates-container');
                    if (newsSection) {
                        newsSection.scrollIntoView({ 
                            behavior: 'smooth', 
                            block: 'start' 
                        });
                        
                        // Add pulse animation to news section
                        newsSection.style.animation = 'none';
                        setTimeout(function() {
                            newsSection.style.animation = 'pulse 0.6s ease-in-out';
                        }, 10);
                    }
                });
            }
            
            // Optional: Add floating label effect for better UX
            var formControls = document.querySelectorAll('.form-control');
            if (formControls && formControls.length > 0) {
                formControls.forEach(function(control) {
                    control.addEventListener('focus', function() {
                        if (this.parentNode) this.parentNode.classList.add('focused');
                    });
                    control.addEventListener('blur', function() {
                        if (this.parentNode) this.parentNode.classList.remove('focused');
                    });
                });
            }
            
            // Optional: Show loading state on form submit (visual feedback only)
            var loginForm = document.getElementById('form1');
            if (loginForm) {
                loginForm.addEventListener('submit', function(e) {
                    // Don't prevent default - let ASP.NET handle everything
                    var loginBtn = document.querySelector('.btn-primary');
                    if (loginBtn && !loginBtn.disabled) {
                        loginBtn.innerHTML = '<i class="fas fa-spinner fa-spin"></i> جاري التحقق...';
                        loginBtn.disabled = true;
                    }
                });
            }
        });
        
        // Additional security: Clear password on page unload
        window.addEventListener('beforeunload', function() {
            var passwordField = document.getElementById('<%= txtPassword.ClientID %>');
            if (passwordField) {
                passwordField.value = '';
            }
        });
    </script>
</body>
</html>
