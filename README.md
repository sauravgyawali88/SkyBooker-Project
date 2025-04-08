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
