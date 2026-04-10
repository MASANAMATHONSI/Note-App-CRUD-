 C# & SQL Server Notepad App
A streamlined Windows Desktop application built with C# and SQL Server for efficient note management. 
This app features a dynamic search system and a dual-form interface for seamless navigation and editing.

 Features
1.Smart Search: Find notes by title using partial matches (contains logic).
2.Navigation Hub: A central dashboard to view all notes and launch actions.
3.Full CRUD Functionality: Create, Read, Update, and Delete notes with ease.
4.Dual-Form Interface: * Form 1 (Navigation): Search and browse your note library.
5.Form 2 (Editor): Detailed view for editing existing notes or drafting new ones.

Tech Stack
Language: C# (.NET Framework/Core)
IDE: Visual Studio
Database: Microsoft SQL Server
Database Management: SQL Server Management Studio (SSMS)

 Application Flow
1. Navigation & Search (Main Form)
When you launch the app, the Navigation Form opens.

Search Logic: The search bar is designed to be flexible. If you have a note titled "PO1 Report" and you search for "PO1", the system will pull up all matching records.

Selection: Selecting a note from the search results transitions you to the Editor Form.

2. Note Management (Editor Form)
The second form provides the "heavy lifting":

Add: Save new entries directly to the SQL database.

Edit: Modify the contents of a selected note.

Delete: Remove outdated records permanently.
