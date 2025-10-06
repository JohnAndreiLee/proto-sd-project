# Authentication Guide

## Overview

The Consultation Management System API uses multiple authentication methods to secure endpoints and protect user data. This guide explains how to authenticate with the API and use the available security schemes.

## Authentication Methods

### 1. JWT Bearer Token Authentication (Recommended)

**Scheme:** `Bearer`
**Header:** `Authorization: Bearer <token>`

JWT (JSON Web Token) authentication is the recommended method for API access. Tokens are issued after successful login and must be included in the Authorization header for protected endpoints.

#### How to Obtain a JWT Token

1. **Register a new user** (if needed):
   ```http
   POST /api/Authentication/UserRegister
   Content-Type: application/json

   {
     "userEmail": "student@university.edu",
     "umid": "2024001",
     "userPassword": "SecurePassword123!",
     "studentName": "John Doe",
     "userType": 0
   }
   ```

2. **Login to get a token**:
   ```http
   POST /api/Authentication/UserLogin
   Content-Type: application/json

   {
     "userEmail": "student@university.edu",
     "userPassword": "SecurePassword123!"
   }
   ```

3. **Use the token in subsequent requests**:
   ```http
   GET /api/Dashboard/ShowForStudents/1
   Authorization: Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9...
   ```

#### Token Format

JWT tokens contain three parts separated by dots:
- **Header**: Algorithm and token type
- **Payload**: User claims and permissions
- **Signature**: Verification signature

Example token structure:
```
eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxMjM0NTY3ODkwIiwibmFtZSI6IkpvaG4gRG9lIiwiaWF0IjoxNTE2MjM5MDIyfQ.SflKxwRJSMeKKF2QT4fwpMeJf36POk6yJV_adQssw5c
```

### 2. API Key Authentication

**Scheme:** `ApiKey`
**Header:** `X-API-Key: <your-api-key>`

API keys provide a simple authentication method for server-to-server communication or automated systems.

#### How to Use API Keys

1. **Obtain an API key** from your system administrator
2. **Include the key in requests**:
   ```http
   GET /api/Consultation/ShowConsultation/1
   X-API-Key: your-api-key-here
   ```

### 3. Cookie Authentication

**Scheme:** `Cookie`
**Method:** Session-based authentication

Cookie authentication uses ASP.NET Core Identity's built-in session management. Cookies are automatically managed by the browser after login.

#### How Cookie Authentication Works

1. **Login through the web interface** or API
2. **Authentication cookie is set automatically**
3. **Subsequent requests include the cookie automatically**

### 4. OAuth2 (Future Implementation)

**Scheme:** `OAuth2`
**Flow:** Authorization Code Flow

OAuth2 support is planned for future releases to enable third-party integrations and enhanced security.

## User Roles and Permissions

### Student Role
- **Access Level:** Limited to own data
- **Permissions:**
  - Create consultation requests
  - View own consultations
  - Access own dashboard
  - View own course information

### Faculty Role
- **Access Level:** Course-related data
- **Permissions:**
  - View consultation requests for their courses
  - Approve/disapprove consultation requests
  - Access student information for their courses
  - Manage consultation schedules

### Admin Role
- **Access Level:** Full system access
- **Permissions:**
  - Manage all users and data
  - Access system logs and analytics
  - Configure system settings
  - Override business rules when necessary

## Error Responses

### Authentication Errors

#### 401 Unauthorized
```json
{
  "message": "Authentication required",
  "error": "Valid JWT token must be provided",
  "timestamp": "2024-12-15T14:30:00Z",
  "trackingId": "AUTH-2024-12-15-001"
}
```

#### 403 Forbidden
```json
{
  "message": "Access denied",
  "error": "Student role required",
  "timestamp": "2024-12-15T14:30:00Z",
  "trackingId": "AUTH-2024-12-15-002"
}
```

### Token Validation Errors

#### Expired Token
```json
{
  "message": "Token expired",
  "error": "JWT token has expired and must be renewed",
  "timestamp": "2024-12-15T14:30:00Z",
  "trackingId": "TOKEN-2024-12-15-001"
}
```

#### Invalid Token
```json
{
  "message": "Invalid token",
  "error": "JWT token is malformed or invalid",
  "timestamp": "2024-12-15T14:30:00Z",
  "trackingId": "TOKEN-2024-12-15-002"
}
```

## Testing Authentication in Swagger UI

### Using JWT Bearer Tokens

1. **Open Swagger UI** at `/swagger`
2. **Click the "Authorize" button** (lock icon)
3. **Select "Bearer" authentication**
4. **Enter your token** in the format: `Bearer your-jwt-token-here`
5. **Click "Authorize"**
6. **Test protected endpoints**

### Using API Keys

1. **Click the "Authorize" button** in Swagger UI
2. **Select "ApiKey" authentication**
3. **Enter your API key** in the value field
4. **Click "Authorize"**
5. **Test protected endpoints**

## Best Practices

### Token Security
- **Never expose tokens** in client-side code
- **Use HTTPS** for all authentication requests
- **Store tokens securely** (e.g., secure HTTP-only cookies)
- **Implement token refresh** for long-lived applications
- **Set appropriate token expiration** times

### API Key Security
- **Rotate API keys** regularly
- **Use different keys** for different environments
- **Monitor API key usage** for suspicious activity
- **Revoke compromised keys** immediately

### General Security
- **Validate all inputs** on both client and server
- **Use strong passwords** with complexity requirements
- **Implement rate limiting** to prevent abuse
- **Log authentication events** for security monitoring
- **Keep authentication libraries** up to date

## Troubleshooting

### Common Issues

#### "Authentication required" Error
- **Cause:** Missing or invalid Authorization header
- **Solution:** Ensure the Authorization header is included with a valid token

#### "Access denied" Error
- **Cause:** Insufficient permissions for the requested resource
- **Solution:** Verify user role and permissions

#### "Token expired" Error
- **Cause:** JWT token has exceeded its expiration time
- **Solution:** Obtain a new token by logging in again

#### "Invalid token format" Error
- **Cause:** Malformed JWT token or incorrect header format
- **Solution:** Verify token format and Authorization header syntax

### Getting Help

If you encounter authentication issues:

1. **Check the error response** for specific error codes and tracking IDs
2. **Verify your token** using JWT debugging tools
3. **Review the API documentation** for endpoint-specific requirements
4. **Contact support** with the tracking ID for assistance

## Examples

### Complete Authentication Flow

```javascript
// 1. Register a new user
const registerResponse = await fetch('/api/Authentication/UserRegister', {
  method: 'POST',
  headers: {
    'Content-Type': 'application/json'
  },
  body: JSON.stringify({
    userEmail: 'student@university.edu',
    umid: '2024001',
    userPassword: 'SecurePassword123!',
    studentName: 'John Doe',
    userType: 0
  })
});

// 2. Login to get a token
const loginResponse = await fetch('/api/Authentication/UserLogin', {
  method: 'POST',
  headers: {
    'Content-Type': 'application/json'
  },
  body: JSON.stringify({
    userEmail: 'student@university.edu',
    userPassword: 'SecurePassword123!'
  })
});

const loginData = await loginResponse.json();
const token = loginData.token; // Assuming the API returns a token

// 3. Use the token for authenticated requests
const dashboardResponse = await fetch('/api/Dashboard/ShowForStudents/1', {
  headers: {
    'Authorization': `Bearer ${token}`
  }
});

const dashboardData = await dashboardResponse.json();
```

### cURL Examples

```bash
# Register a new user
curl -X POST "https://api.consultationsystem.com/api/Authentication/UserRegister" \
  -H "Content-Type: application/json" \
  -d '{
    "userEmail": "student@university.edu",
    "umid": "2024001",
    "userPassword": "SecurePassword123!",
    "studentName": "John Doe",
    "userType": 0
  }'

# Login to get a token
curl -X POST "https://api.consultationsystem.com/api/Authentication/UserLogin" \
  -H "Content-Type: application/json" \
  -d '{
    "userEmail": "student@university.edu",
    "userPassword": "SecurePassword123!"
  }'

# Use the token for authenticated requests
curl -X GET "https://api.consultationsystem.com/api/Dashboard/ShowForStudents/1" \
  -H "Authorization: Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9..."
```