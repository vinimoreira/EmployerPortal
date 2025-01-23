# EmployerPortal Refactoring Challenge

This project is part of a technical challenge focused on refactoring a legacy application written in Classic ASP into ASP.NET Core (C#), emphasizing security best practices and modern development standards.

## Overview

The challenge involves modernizing a legacy application, analyzing provided code snippets to identify vulnerabilities such as SQL injection, and refactoring it to a secure and efficient ASP.NET Core implementation.

## Challenge Description

- **Challenge Title:** Legacy Application Refactoring
- **Objective:** Modernize a legacy code snippet into an ASP.NET Core (C#) structure, addressing vulnerabilities and implementing secure coding practices.
- **Key Tasks:**
  - Analyze the provided legacy code.
  - Identify security vulnerabilities and suggest improvements.
  - Refactor the code into a secure, modern C# implementation.

## Legacy Code Snippet (Classic ASP)

The following code snippet was provided as an example of the legacy application. It contains vulnerabilities like SQL injection and will be refactored into a secure implementation.

```asp
<%
Response.Write("Welcome to the Employer Portal!")
dim username
username = Request("username")
' Potential SQL injection vulnerability
sql = "SELECT * FROM Users WHERE username = '" & username & "'"
Set rs = conn.Execute(sql)
If not rs.EOF Then
    Response.Write("Hello, " & rs("name"))
Else
    Response.Write("User not found.")
End If
%>
```

### Requirements

1. Identify at least two security vulnerabilities in the code.
2. Refactor the code into an ASP.NET Core controller.
3. Use parameterized queries to prevent SQL injection.
4. Ensure the refactored code follows best practices for error handling and response formatting.

## Technologies Used

- **Legacy:** Classic ASP
- **Modernized:** ASP.NET Core (C#)
- **Database:** SQL Server

## How to Run the Refactored Project

1. **Clone the Repository**
   ```bash
   git clone https://github.com/vinimoreira/EmployerPortal.git
   ```

2. **Navigate to the Project Directory**
   ```bash
   cd EmployerPortal.Api
   ```

3. **Restore Dependencies**
   ```bash
   dotnet restore
   ```

4. **Run the Application**
   ```bash
   dotnet run
   ```

5. **Access the Application**
   - Open your browser and navigate to `http://localhost:5198/swagger/index.html`.

## How to Execute the Tests

The project includes unit tests to ensure the functionality and security of the refactored code.

1. **Navigate to the Test Project Directory**
   ```bash
   cd EmployerPortal.Test
   ```

2. **Run All Tests**
   ```bash
   dotnet test
   ```

3. **View Test Results**
   - The output of the `dotnet test` command will display the results of the tests, including any failures or errors.
   - Test coverage reports (if configured) will also be generated in the specified location.

## Security Improvements Implemented

- **Parameterized Queries:** Prevent SQL injection attacks.
- **Input Validation:** Ensure user-provided data is sanitized and secure.
- **Error Handling:** Provide clear and secure error messages for unexpected failures.
- **Improved Response Formatting:** Enhance the user experience with consistent responses.

## Contribution

Contributions are welcome! Feel free to open an issue or submit a pull request with suggestions or improvements.

## License

This project is licensed under the MIT License. See the `LICENSE` file for more details.
