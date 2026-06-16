# TestingClaude

A Windows Forms app with **Login** and **Register** connected to a XAMPP MySQL database.

## Requirements
- Visual Studio 2019/2022 Community
- XAMPP with MySQL running
- .NET Framework 4.7.2

## Database Setup
1. Start XAMPP and ensure **MySQL** is running.
2. Open **phpMyAdmin** at `http://localhost/phpmyadmin`.
3. Import `database/testingclaude.sql`.

## Running
1. Open `TestingClaude.sln` in Visual Studio.
2. Build (NuGet restores `MySql.Data` automatically).
3. Run the project.

## Connection String (in `DatabaseHelper.cs`)
```
Server=localhost;Database=testingclaude;Uid=root;Pwd=;
```
Update `Pwd=` if your XAMPP MySQL has a password.

## Features
- **Register**: Username, Email, Password, Confirm Password — shows `"successfully registered"`
- **Login**: Username + Password — shows `"loged in successfully"`
- Passwords stored as SHA-256 hashes.
