# Feedbacker 2.0 - Windows Forms Application for Teachers

**Feedbacker 2.0** is a Windows Forms application developed in .NET 6, designed to assist teachers in managing and providing feedback for different assignments across various courses. The program utilizes an SQLite database for data storage and retrieval.

## Features

- **Course Management:** Add, edit, and organize courses for efficient assignment tracking.
- **Assignment Tracking:** Easily manage assignments within each course.
- **Feedback Comments:** Provide and edit feedback comments for individual assignments.
- **Useful Tools:** Easily add your signature and a grade aim for the feedbacks.
- **Save and Load:** Save your project to an SQLite database file and load existing projects for continued work.
- **Installer:** An installer is available for a seamless installation experience.

## System Requirements

- **.NET 6:** Ensure that you have .NET 6 runtime installed on your machine to run Feedbacker 2.0.

## Getting Started

To get started with Feedbacker 2.0, follow these steps:

1. **Download:** Clone the repository or download the installer from the [Releases](https://github.com/Rymdhest/Feedbacker-2.0/releases) section.
2. **Installation:** Run the installer to set up Feedbacker 2.0 on your system.
3. **Create or Load Project:** Start a new project or load an existing one.

## Database Management

Feedbacker 2.0 uses an SQLite database to store your project data. The `DatabaseManager` class handles all the interaction with the database.

### Database Schema

- **courses:** Stores information about courses, including name and description.
- **assignments:** Contains details about assignments, including name and description.
- **responses:** Holds feedback responses with title and text.
[feedbacker](https://github.com/Rymdhest/Feedbacker-2.0/assets/52751206/0d6a9b64-fd5a-4abf-96f6-68c87d08e61e)

<img src="https://github.com/Rymdhest/Feedbacker-2.0/assets/52751206/0d6a9b64-fd5a-4abf-96f6-68c87d08e61e" width="800"/>


## Under the Hood!


The program employs a caching mechanism. When a database is loaded the entire database is queried and stored in a class hierarchy imitating the database structure. When saving, the database is first fully cleared and then the cached data is inserted back into the database. This means that the entire database is rewritten if the user only wanta to save one small change. This may seem like a naive approach but it works remarkably well and ensures that the database always contains synchronized information.

---

**Developed by Gustav Holmström | [GitHub Profile](https://github.com/Rymdhest)**
