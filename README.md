# Exam.UserManager

## Instructions for Exam Takers

This project contains incomplete code that you need to finish as part of the exam. Your task is to locate and complete all the TODO items in the codebase. Each TODO item is marked with a comment in the format `// TODO: ...`.

### Steps to Complete the Exam

1. Clone this repository to your local machine.
2. Open the project in your preferred code editor.
3. Search for all `TODO` comments in the codebase.
4. Complete the code as instructed in each TODO comment.
5. Test your API with Postman or Swagger, make sure to update the appsettings for the Security before testing:
```json
  "Security": {
    "BypassRead": true,
    "BypassWrite": true
  },
```
6. Test your changes to ensure they work as expected.
7. Submit your completed project as per the submission guidelines provided.

### List of TODO Items

- UserQueryService: Implement the logic to get all users. (5pts)
- UserWriteService: Implement the logic to update user. (5pts)
- UserWriteService: Implement the logic to delete user. (5pts)
- UserController: Implement the logic to get user by id. (5pts)
- UserController: Implement the logic to add user. (5pts)
- UserController: Implement the logic to update user. (5pts)

- No Compilation Errors (5pts)
- API is working overall (10pts)
- Effort :D (5pts)


Good luck!