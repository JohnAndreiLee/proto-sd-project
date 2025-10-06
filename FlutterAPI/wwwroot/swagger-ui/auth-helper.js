/**
 * Authentication Helper for Swagger UI
 * Provides enhanced authentication testing capabilities
 */

(function() {
    'use strict';

    // Wait for Swagger UI to load
    window.addEventListener('load', function() {
        setTimeout(initializeAuthHelper, 1000);
    });

    function initializeAuthHelper() {
        addAuthenticationExamples();
        addQuickAuthButtons();
        enhanceAuthorizationModal();
        addTokenValidation();
    }

    /**
     * Add authentication examples to the UI
     */
    function addAuthenticationExamples() {
        const authSection = document.querySelector('.auth-wrapper');
        if (!authSection) return;

        const examplesDiv = document.createElement('div');
        examplesDiv.className = 'auth-examples';
        examplesDiv.innerHTML = `
            <div class="auth-examples-container">
                <h4>Authentication Examples</h4>
                
                <div class="auth-example">
                    <h5>JWT Bearer Token</h5>
                    <p>Format: <code>Bearer &lt;your-jwt-token&gt;</code></p>
                    <p>Example: <code>Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9...</code></p>
                    <button class="btn btn-sm btn-outline-primary" onclick="copyToClipboard('Bearer ')">Copy Format</button>
                </div>
                
                <div class="auth-example">
                    <h5>API Key</h5>
                    <p>Header: <code>X-API-Key</code></p>
                    <p>Value: <code>your-api-key-here</code></p>
                    <button class="btn btn-sm btn-outline-primary" onclick="copyToClipboard('your-api-key-here')">Copy Example</button>
                </div>
                
                <div class="auth-example">
                    <h5>How to Get a JWT Token</h5>
                    <ol>
                        <li>Register: <code>POST /api/Authentication/UserRegister</code></li>
                        <li>Login: <code>POST /api/Authentication/UserLogin</code></li>
                        <li>Copy the token from the response</li>
                        <li>Use format: <code>Bearer &lt;token&gt;</code></li>
                    </ol>
                </div>
            </div>
        `;

        authSection.appendChild(examplesDiv);
    }

    /**
     * Add quick authentication buttons
     */
    function addQuickAuthButtons() {
        const topbar = document.querySelector('.topbar');
        if (!topbar) return;

        const quickAuthDiv = document.createElement('div');
        quickAuthDiv.className = 'quick-auth-buttons';
        quickAuthDiv.innerHTML = `
            <div class="quick-auth-container">
                <button class="btn btn-sm btn-success" onclick="quickLogin()">Quick Test Login</button>
                <button class="btn btn-sm btn-info" onclick="showAuthGuide()">Auth Guide</button>
                <button class="btn btn-sm btn-warning" onclick="validateToken()">Validate Token</button>
            </div>
        `;

        topbar.appendChild(quickAuthDiv);
    }

    /**
     * Enhance the authorization modal with better UX
     */
    function enhanceAuthorizationModal() {
        // Add event listener for when authorization modal opens
        document.addEventListener('click', function(e) {
            if (e.target.classList.contains('authorize') || e.target.closest('.authorize')) {
                setTimeout(enhanceModalContent, 100);
            }
        });
    }

    function enhanceModalContent() {
        const modal = document.querySelector('.auth-container');
        if (!modal) return;

        // Add helpful text to Bearer token input
        const bearerInput = modal.querySelector('input[placeholder*="Bearer"]');
        if (bearerInput) {
            bearerInput.placeholder = 'Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9...';
            
            // Add validation on input
            bearerInput.addEventListener('input', function() {
                validateBearerToken(this);
            });
        }

        // Add helpful text to API key input
        const apiKeyInput = modal.querySelector('input[name="X-API-Key"]');
        if (apiKeyInput) {
            apiKeyInput.placeholder = 'your-api-key-here';
        }
    }

    /**
     * Add token validation functionality
     */
    function addTokenValidation() {
        window.validateToken = function() {
            const authHeader = getStoredAuth();
            if (!authHeader) {
                showNotification('No authentication token found. Please authorize first.', 'warning');
                return;
            }

            if (authHeader.startsWith('Bearer ')) {
                const token = authHeader.substring(7);
                try {
                    const payload = JSON.parse(atob(token.split('.')[1]));
                    const exp = payload.exp * 1000; // Convert to milliseconds
                    const now = Date.now();
                    
                    if (exp < now) {
                        showNotification('Token has expired. Please login again.', 'error');
                    } else {
                        const timeLeft = Math.floor((exp - now) / 1000 / 60); // Minutes
                        showNotification(`Token is valid. Expires in ${timeLeft} minutes.`, 'success');
                    }
                } catch (e) {
                    showNotification('Invalid token format.', 'error');
                }
            } else {
                showNotification('API Key authentication detected.', 'info');
            }
        };
    }

    /**
     * Quick login functionality for testing
     */
    window.quickLogin = async function() {
        const testCredentials = {
            userEmail: 'test@university.edu',
            userPassword: 'TestPassword123!'
        };

        try {
            showNotification('Attempting test login...', 'info');
            
            const response = await fetch('/api/Authentication/UserLogin', {
                method: 'POST',
                headers: {
                    'Content-Type': 'application/json'
                },
                body: JSON.stringify(testCredentials)
            });

            if (response.ok) {
                const data = await response.json();
                if (data.token) {
                    // Auto-fill the Bearer token
                    const bearerInput = document.querySelector('input[placeholder*="Bearer"]');
                    if (bearerInput) {
                        bearerInput.value = `Bearer ${data.token}`;
                        bearerInput.dispatchEvent(new Event('input'));
                    }
                    showNotification('Test login successful! Token has been auto-filled.', 'success');
                } else {
                    showNotification('Login successful but no token received.', 'warning');
                }
            } else {
                const error = await response.json();
                showNotification(`Login failed: ${error.message || 'Unknown error'}`, 'error');
            }
        } catch (error) {
            showNotification(`Login error: ${error.message}`, 'error');
        }
    };

    /**
     * Show authentication guide
     */
    window.showAuthGuide = function() {
        const guideWindow = window.open('/authentication-guide.md', '_blank');
        if (!guideWindow) {
            showNotification('Please allow popups to view the authentication guide.', 'warning');
        }
    };

    /**
     * Validate Bearer token format
     */
    function validateBearerToken(input) {
        const value = input.value.trim();
        
        if (!value) {
            input.style.borderColor = '';
            return;
        }

        if (!value.startsWith('Bearer ')) {
            input.style.borderColor = '#dc3545';
            input.title = 'Token must start with "Bearer "';
            return;
        }

        const token = value.substring(7);
        if (token.split('.').length !== 3) {
            input.style.borderColor = '#ffc107';
            input.title = 'JWT token should have 3 parts separated by dots';
            return;
        }

        input.style.borderColor = '#28a745';
        input.title = 'Token format looks correct';
    }

    /**
     * Get stored authentication from Swagger UI
     */
    function getStoredAuth() {
        try {
            const auth = localStorage.getItem('swagger-ui-auth');
            if (auth) {
                const authData = JSON.parse(auth);
                return authData.Bearer || authData.ApiKey;
            }
        } catch (e) {
            console.error('Error reading stored auth:', e);
        }
        return null;
    }

    /**
     * Copy text to clipboard
     */
    window.copyToClipboard = function(text) {
        navigator.clipboard.writeText(text).then(function() {
            showNotification('Copied to clipboard!', 'success');
        }).catch(function() {
            showNotification('Failed to copy to clipboard.', 'error');
        });
    };

    /**
     * Show notification to user
     */
    function showNotification(message, type = 'info') {
        const notification = document.createElement('div');
        notification.className = `auth-notification auth-notification-${type}`;
        notification.innerHTML = `
            <div class="auth-notification-content">
                <span>${message}</span>
                <button onclick="this.parentElement.parentElement.remove()">&times;</button>
            </div>
        `;

        document.body.appendChild(notification);

        // Auto-remove after 5 seconds
        setTimeout(() => {
            if (notification.parentElement) {
                notification.remove();
            }
        }, 5000);
    }

    // Add CSS styles
    const style = document.createElement('style');
    style.textContent = `
        .auth-examples-container {
            margin: 20px 0;
            padding: 15px;
            border: 1px solid #e3e3e3;
            border-radius: 4px;
            background-color: #f9f9f9;
        }

        .auth-example {
            margin-bottom: 15px;
            padding: 10px;
            background-color: white;
            border-radius: 4px;
        }

        .auth-example h5 {
            margin: 0 0 10px 0;
            color: #3b4151;
        }

        .auth-example code {
            background-color: #f7f7f7;
            padding: 2px 4px;
            border-radius: 3px;
            font-family: monospace;
        }

        .quick-auth-container {
            display: flex;
            gap: 10px;
            align-items: center;
            margin-left: auto;
        }

        .quick-auth-buttons {
            margin-left: auto;
        }

        .btn {
            padding: 5px 10px;
            border: 1px solid;
            border-radius: 4px;
            cursor: pointer;
            text-decoration: none;
            display: inline-block;
        }

        .btn-sm {
            padding: 3px 8px;
            font-size: 12px;
        }

        .btn-success {
            background-color: #28a745;
            border-color: #28a745;
            color: white;
        }

        .btn-info {
            background-color: #17a2b8;
            border-color: #17a2b8;
            color: white;
        }

        .btn-warning {
            background-color: #ffc107;
            border-color: #ffc107;
            color: #212529;
        }

        .btn-outline-primary {
            background-color: transparent;
            border-color: #007bff;
            color: #007bff;
        }

        .btn:hover {
            opacity: 0.8;
        }

        .auth-notification {
            position: fixed;
            top: 20px;
            right: 20px;
            z-index: 10000;
            max-width: 400px;
            border-radius: 4px;
            box-shadow: 0 2px 10px rgba(0,0,0,0.1);
        }

        .auth-notification-content {
            padding: 12px 16px;
            display: flex;
            justify-content: space-between;
            align-items: center;
        }

        .auth-notification-success {
            background-color: #d4edda;
            border: 1px solid #c3e6cb;
            color: #155724;
        }

        .auth-notification-error {
            background-color: #f8d7da;
            border: 1px solid #f5c6cb;
            color: #721c24;
        }

        .auth-notification-warning {
            background-color: #fff3cd;
            border: 1px solid #ffeaa7;
            color: #856404;
        }

        .auth-notification-info {
            background-color: #d1ecf1;
            border: 1px solid #bee5eb;
            color: #0c5460;
        }

        .auth-notification button {
            background: none;
            border: none;
            font-size: 18px;
            cursor: pointer;
            padding: 0;
            margin-left: 10px;
        }
    `;
    document.head.appendChild(style);

})();