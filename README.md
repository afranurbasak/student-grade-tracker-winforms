# Student Grade Tracker (WinForms)

Desktop application for recording students and their courses, computing weighted averages and pass/fail status. Code is organised into **Model** and **Controller** layers separate from the form.

## Features

- Add students (name, surname, number, department) with duplicate-number checks
- Add courses per student (code, name, credits, midterm and final scores)
- Average = 40% midterm + 60% final; pass threshold 50
- Input validation on numeric fields

## Structure

```
OgrenciNotSistemi/
  Model/Student.cs, Model/Course.cs
  Controller/StudentController.cs
  Form1.cs                      # UI
```

## Build

Open `OgrenciNotSistemi.sln` in Visual Studio and run (.NET Framework, Windows Forms).

UI text is in Turkish.
