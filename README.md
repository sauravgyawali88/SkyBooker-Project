# SkyBooker (Flight Booking Project) - This project is a flight booking system designed using XAML, MVVM architecture, and Git for version control. The system allows users to search for flights, make bookings, and process payments securely.
## Main Models:
- **Airport**: Contains details about airports such as location, name, and code.
- **Booking**: Manages user bookings and stores relevant information such as user details, flight choice, and booking status.
- **Flight**: Contains details about flights including airline, departure/arrival times, price, etc.
- **Payment**: Manages payment processing, integrates with the booking system for confirming payments.
## Git Usage
- Created a `feature-flight` branch for implementing flight booking functionality.
- Used **merge** to combine the feature branches with the `master` branch.
- Commit messages were structured clearly to document the progress of each feature, like "Implemented Payment Model for flight booking."
# Reflective Analysis

Throughout the development of the SkyBooker project, Git played a crucial role in managing my codebase and streamlining my workflow. I used Git to implement several models using the MVVM architecture, including User, Payment, Flight, and Airport. For instance, in the User model, I added data annotations for validation, ensuring that fields like UserName, Email, and Password met specific criteria. This was tracked effectively with clear commit messages like “Enhance User Model with Data Annotations for Validation,” which allowed me to maintain a structured history of changes.

Branching allowed me to work on different features independently. I worked on the Payment and Flight models in separate branches, and once the features were complete, I merged them into the main branch. This approach helped prevent conflicts and facilitated smoother integration of new features.

In addition, using Git’s commit history made it easy to track the development of complex functionalities, such as creating ViewModels and Views for the Flight and Payment models, including FlightViewModel and PaymentViewModel. This structured version control system helped me stay organized, manage multiple features simultaneously, and collaborate effectively. Overall, Git significantly improved my development process, ensuring the project’s progress was efficient and error-free.






# ✈️ SkyBooker – Flight Booking App

SkyBooker is a mobile application developed to simplify flight bookings by offering a seamless and user-friendly interface. The app allows users to search for flights, view detailed flight information, and filter based on personal preferences.
---

## 📌 Project Objectives

- Allow users to search and filter available flights.
- Display detailed information such as flight duration, departure, and arrival times.
- Provide a simple and clean UI/UX for better usability.
- Apply Git-based version control throughout the development lifecycle.
- Practice modular, scalable, and maintainable coding patterns.
---

## 🧰 Tech Stack

- **Language:** C#
- **Backend (optional):** Firebase
- **Version Control:** Git & GitHub

---

## 🔧 Features Implemented

- `TaskCount` property in the **Project** model to return the number of tasks associated with a project.
- Overridden `ToString()` method in the **User** model to display user details in a formatted string.
- `FlightDuration` property in the **Flight** model to automatically calculate total duration between arrival and departure.

---

## Git Version Control Usage

Version control using **Git** was implemented throughout this project. Here’s how Git was used:

- **Branches:**  
  - `main`: Stable codebase  
  - `feature-flight-duration`, `feature-user-tostring`, `feature-taskcount`: For developing new features independently

- **Commits:**  
  Each commit includes detailed messages describing the purpose and impact of code changes.

- **Merging:**  
  After testing features in their respective branches, they were merged into `main` to ensure code stability.

- **Documentation:**  
  GitHub served as the central platform to store project history, track progress, and maintain transparency in development.

# Reflective Analysis
Usage of Git and GitHub on the SkyBooker project actually assisted me in developing my development planning and management. With the help of Git, I was able to get my code changes traceable in detail and managed. I utilized different branches for feature development like the TaskCount on the Project model, the ToString() feature on the User model, and the FlightDuration feature on the Flight model. With this, I was able to develop each feature without affecting the overall application.

Each commit I made came with simple and descriptive messages, so it is easier to discern what has been altered and why. It was much easier to debug problems and monitor progress. Though I've done the project solo, Git allowed me to simulate how a team-oriented development would be like by practicing extensively in branching and merging.

Overall, using version control tools like Git made my project more efficient overall. It made me see how important clean commit history, tidy branches, and good documentation are—skills that a commercial software developer should possess.

