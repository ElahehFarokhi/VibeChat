# VibeChat

VibeChat is a real-time messaging platform that enables users to engage in private conversations or participate in public discussion. Built with Angular and .NET, it leverages SignalR for seamless communication and utilizes in-memory caching for enhanced performance.

---

## Features

- **Private Messaging:** Engage in one-on-one conversations with other users.
- **Public Group Chats:** Discuss topics of interest publicly with anyone who is logged in.
- **Real-Time Communication:** Experience instant messaging powered by SignalR.

---

## Technologies Used

### Backend

- **Framework:** .NET 8
- **Real-Time Communication:** SignalR
- **Caching:** In-memory caching using .NET's built-in capabilities

### Frontend

- **Framework:** Angular 18
- **Styling:** Bootstrap CSS
- **Real-Time Updates:** SignalR integration

---

## Getting Started

### Prerequisites

- .NET SDK
- Node.js and npm
- Angular CLI

### Backend Setup

1. **Clone the Repository:**

   ```bash
   git clone https://github.com/ElahehFarokhi/VibeChat.git
   ```

2. **Navigate to the Backend Directory:**

   ```bash
   cd VibeChat/Backend
   ```

3. **Restore Dependencies:**

   ```bash
   dotnet restore
   ```

4. **Update Configuration:**

   Modify the `appsettings.json` file to include your specific configurations, such as connection strings and authentication settings.

5. **Run the Application:**

   ```bash
   dotnet run
   ```

### Frontend Setup

1. **Navigate to the Frontend Directory:**

   ```bash
   cd VibeChat/Frontend
   ```

2. **Install Dependencies:**

   ```bash
   npm install
   ```

3. **Update Environment Settings:**

   Modify the `environment.ts` file to include your API endpoints and other configurations.

4. **Start the Development Server:**

   ```bash
   ng serve
   ```

5. **Access the Application:**

   Open your browser and navigate to `http://localhost:4200`.

---

## Contributing

Contributions are welcome! Please fork the repository and create a pull request with your changes. Ensure that your code adheres to the project's coding standards and includes appropriate tests.
