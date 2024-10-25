
# 🎥 Movies Review Website 🍿

Welcome to the **Movies Review Website**! This full-stack web application allows users to browse, search, and review movies. Built using ASP.NET Core and Entity Framework Core, the app supports CRUD operations (Create, Read, Update, Delete) for movies, genres, user reviews, and more.

---

## 🛠️ Technologies Used

- **.NET 8** (ASP.NET Core MVC)
- **Entity Framework Core** (for database interactions)
- **SQL Server** (for database)
- **Bootstrap 5** (for responsive UI design)
- **FontAwesome** (for icons)
- **LINQ** (for database querying)
- **AutoMapper** (for object mapping)
- **Clean Architecture** (for project structure)

---

## 🌟 Features

1. **Movie Listing**:  
   - View a list of all movies in the database, including details like title, description, genre, release date, and average rating.  
   ![Movie Listing](https://private-user-images.githubusercontent.com/61979779/380189669-50842b6c-b4fc-4512-8b1f-8170948fe752.png?jwt=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJnaXRodWIuY29tIiwiYXVkIjoicmF3LmdpdGh1YnVzZXJjb250ZW50LmNvbSIsImtleSI6ImtleTUiLCJleHAiOjE3Mjk4NjQ0MjEsIm5iZiI6MTcyOTg2NDEyMSwicGF0aCI6Ii82MTk3OTc3OS8zODAxODk2NjktNTA4NDJiNmMtYjRmYy00NTEyLThiMWYtODE3MDk0OGZlNzUyLnBuZz9YLUFtei1BbGdvcml0aG09QVdTNC1ITUFDLVNIQTI1NiZYLUFtei1DcmVkZW50aWFsPUFLSUFWQ09EWUxTQTUzUFFLNFpBJTJGMjAyNDEwMjUlMkZ1cy1lYXN0LTElMkZzMyUyRmF3czRfcmVxdWVzdCZYLUFtei1EYXRlPTIwMjQxMDI1VDEzNDg0MVomWC1BbXotRXhwaXJlcz0zMDAmWC1BbXotU2lnbmF0dXJlPWIwNmQyZjcxMWYzZTc4ZGM3YzdhZGU1ZmE1ZWJjYjdjMjM3YmFiYWQ5MWUyN2MzNGFiNTQ3MDNkYTM4ZGIzMjQmWC1BbXotU2lnbmVkSGVhZGVycz1ob3N0In0.2mENTQgVT-EaLg1wce0VL779DG6Id-MdIIj2rUVRo24)

2. **Search Functionality**:  
   - Search movies by title or genre using keyword-based search boxes.  
   ![Search Movies](https://private-user-images.githubusercontent.com/61979779/380191069-936dfc79-1647-4895-9ec5-0ce0555223a0.png?jwt=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJnaXRodWIuY29tIiwiYXVkIjoicmF3LmdpdGh1YnVzZXJjb250ZW50LmNvbSIsImtleSI6ImtleTUiLCJleHAiOjE3Mjk4NjQ1MzksIm5iZiI6MTcyOTg2NDIzOSwicGF0aCI6Ii82MTk3OTc3OS8zODAxOTEwNjktOTM2ZGZjNzktMTY0Ny00ODk1LTllYzUtMGNlMDU1NTIyM2EwLnBuZz9YLUFtei1BbGdvcml0aG09QVdTNC1ITUFDLVNIQTI1NiZYLUFtei1DcmVkZW50aWFsPUFLSUFWQ09EWUxTQTUzUFFLNFpBJTJGMjAyNDEwMjUlMkZ1cy1lYXN0LTElMkZzMyUyRmF3czRfcmVxdWVzdCZYLUFtei1EYXRlPTIwMjQxMDI1VDEzNTAzOVomWC1BbXotRXhwaXJlcz0zMDAmWC1BbXotU2lnbmF0dXJlPTU5YjM3MDI1YTNiOWQ2MmQ5YTRkMWFiMjFiMzBhNjJhM2Y4MzE5NWU4YzhiZDAzNmYyZTIzMjY2ZDM5Y2Q5NDQmWC1BbXotU2lnbmVkSGVhZGVycz1ob3N0In0.-g5fFMuAEDavauzrh3C32-iCeW8E_xrME1grtcCGSaQ)

3. **Movie Details**:  
   - View detailed information about a single movie, including its title, description, genre, release date, user reviews, and the movie poster.  
   ![Movie Details](https://private-user-images.githubusercontent.com/61979779/380189734-20996445-fda6-4c1c-9d14-5602c7138cbd.png?jwt=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJnaXRodWIuY29tIiwiYXVkIjoicmF3LmdpdGh1YnVzZXJjb250ZW50LmNvbSIsImtleSI6ImtleTUiLCJleHAiOjE3Mjk4NjQ1MzksIm5iZiI6MTcyOTg2NDIzOSwicGF0aCI6Ii82MTk3OTc3OS8zODAxODk3MzQtMjA5OTY0NDUtZmRhNi00YzFjLTlkMTQtNTYwMmM3MTM4Y2JkLnBuZz9YLUFtei1BbGdvcml0aG09QVdTNC1ITUFDLVNIQTI1NiZYLUFtei1DcmVkZW50aWFsPUFLSUFWQ09EWUxTQTUzUFFLNFpBJTJGMjAyNDEwMjUlMkZ1cy1lYXN0LTElMkZzMyUyRmF3czRfcmVxdWVzdCZYLUFtei1EYXRlPTIwMjQxMDI1VDEzNTAzOVomWC1BbXotRXhwaXJlcz0zMDAmWC1BbXotU2lnbmF0dXJlPTgyMmI4ZDRkYjI4M2M1OWUxZmJjZTVmYWRlYTljYzMwMDMxZTVjZmI3NjhlM2YzMjkyMTlmNWYzNGFlN2MyNGQmWC1BbXotU2lnbmVkSGVhZGVycz1ob3N0In0.B1rrjUD-1_29n0yiOzm9fH7ZzFvKxMHQMwBlIs0v7fg)

4. **Movie Reviews**:  
   - Users can submit reviews for individual movies. Reviews are displayed on the movie's details page.  
   ![Movie Reviews](https://private-user-images.githubusercontent.com/61979779/380189768-34c6725f-a24f-43c8-918f-16d40a9c177b.png?jwt=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJnaXRodWIuY29tIiwiYXVkIjoicmF3LmdpdGh1YnVzZXJjb250ZW50LmNvbSIsImtleSI6ImtleTUiLCJleHAiOjE3Mjk4NjQ1MzksIm5iZiI6MTcyOTg2NDIzOSwicGF0aCI6Ii82MTk3OTc3OS8zODAxODk3NjgtMzRjNjcyNWYtYTI0Zi00M2M4LTkxOGYtMTZkNDBhOWMxNzdiLnBuZz9YLUFtei1BbGdvcml0aG09QVdTNC1ITUFDLVNIQTI1NiZYLUFtei1DcmVkZW50aWFsPUFLSUFWQ09EWUxTQTUzUFFLNFpBJTJGMjAyNDEwMjUlMkZ1cy1lYXN0LTElMkZzMyUyRmF3czRfcmVxdWVzdCZYLUFtei1EYXRlPTIwMjQxMDI1VDEzNTAzOVomWC1BbXotRXhwaXJlcz0zMDAmWC1BbXotU2lnbmF0dXJlPTM2YzdiYTIwZTFiY2UzZTM3MjY3NWVmZWRjYTI1YjkzNjI4ZDI3NGI1MGNhNjY5Y2VjMzFmYjcyM2UyMjllZjQmWC1BbXotU2lnbmVkSGVhZGVycz1ob3N0In0.mJNrfCWQX9xhbZlfiYQFD_qxW6oqSTyZg0t7jYoIMcA)

5. **Genres**:  
   - Users can add genres to categorize movies, allowing users to filter movies by genre.  
   ![Genres]([https://github.com/yourusername/reponame/blob/main/images/genres.png](https://private-user-images.githubusercontent.com/61979779/380189758-281a8fec-b07c-4ede-9eec-daa650cf5a16.png?jwt=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJnaXRodWIuY29tIiwiYXVkIjoicmF3LmdpdGh1YnVzZXJjb250ZW50LmNvbSIsImtleSI6ImtleTUiLCJleHAiOjE3Mjk4NjQ1MzksIm5iZiI6MTcyOTg2NDIzOSwicGF0aCI6Ii82MTk3OTc3OS8zODAxODk3NTgtMjgxYThmZWMtYjA3Yy00ZWRlLTllZWMtZGFhNjUwY2Y1YTE2LnBuZz9YLUFtei1BbGdvcml0aG09QVdTNC1ITUFDLVNIQTI1NiZYLUFtei1DcmVkZW50aWFsPUFLSUFWQ09EWUxTQTUzUFFLNFpBJTJGMjAyNDEwMjUlMkZ1cy1lYXN0LTElMkZzMyUyRmF3czRfcmVxdWVzdCZYLUFtei1EYXRlPTIwMjQxMDI1VDEzNTAzOVomWC1BbXotRXhwaXJlcz0zMDAmWC1BbXotU2lnbmF0dXJlPTRhN2Y3MDIwYzU1ZWQ4ODUzOThlMjAwMGZlZTljOTI3NGE1ODA2NzRiZGQ5YWM2NmRiNWU5NTNmZTA3NGE4YmUmWC1BbXotU2lnbmVkSGVhZGVycz1ob3N0In0.Pm6TiH0f4eiic7Qge_8OJiZ2ShAlj6vCko9FYdUvEYc))

6. **CRUD Operations**:  
   - **Create**: Add new movies with title, genre, description, release date, and image upload.
   - **Edit**: Update movie details and replace movie images.  
   ![Edit Movie]([https://github.com/yourusername/reponame/blob/main/images/edit-movie.png](https://private-user-images.githubusercontent.com/61979779/380189753-5cfa5413-3611-4e5d-b024-eafa82b18b03.png?jwt=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJnaXRodWIuY29tIiwiYXVkIjoicmF3LmdpdGh1YnVzZXJjb250ZW50LmNvbSIsImtleSI6ImtleTUiLCJleHAiOjE3Mjk4NjQ1MzksIm5iZiI6MTcyOTg2NDIzOSwicGF0aCI6Ii82MTk3OTc3OS8zODAxODk3NTMtNWNmYTU0MTMtMzYxMS00ZTVkLWIwMjQtZWFmYTgyYjE4YjAzLnBuZz9YLUFtei1BbGdvcml0aG09QVdTNC1ITUFDLVNIQTI1NiZYLUFtei1DcmVkZW50aWFsPUFLSUFWQ09EWUxTQTUzUFFLNFpBJTJGMjAyNDEwMjUlMkZ1cy1lYXN0LTElMkZzMyUyRmF3czRfcmVxdWVzdCZYLUFtei1EYXRlPTIwMjQxMDI1VDEzNTAzOVomWC1BbXotRXhwaXJlcz0zMDAmWC1BbXotU2lnbmF0dXJlPWFkYjA3ZjQyNTRlYzk5NTZkMWI0ZmI4Yzg0YzIwZjhhY2NlNTg4MjUzZWE5MjhlNDhjMTgyZmJkNGI1Y2RiMTQmWC1BbXotU2lnbmVkSGVhZGVycz1ob3N0In0.UpWm0ExhzpKj7X9PxwYsWvlRnN1_naqOWw_4vPhpDDc))
   - **Delete**: Remove movies from the database.  

7. **Image Upload**:  
   - Upload or replace movie poster images when adding or editing movies.

8. **Export to PDF**:  
   - Export the list of movies to a PDF document for easy sharing or archiving.

9. **Responsive UI**:  
   - The app uses Bootstrap to ensure a mobile-friendly, responsive design.

---

## 🚀 Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- [Visual Studio](https://visualstudio.microsoft.com/) or any other IDE that supports .NET

### Installation

1. **Clone the repository**:

   ```bash
   git clone https://github.com/your-username/movies-review-website.git
   ```

2. **Navigate to the project folder**:

   ```bash
   cd movies-review-website
   ```

3. **Setup the database**:

   - Update the connection string in `appsettings.json` with your SQL Server details.
   - Run database migrations:

   ```bash
   dotnet ef database update
   ```

4. **Run the application**:

   ```bash
   dotnet run
   ```

5. **Access the app**:

   Open your browser and navigate to `http://localhost:5000` (or the port number shown in your terminal).

---

## 📂 Project Structure

The project follows **Clean Architecture** principles to ensure separation of concerns and ease of maintenance:

- **Core**: Contains domain entities and interfaces for repositories.
- **Infrastructure**: Contains the actual implementation of repositories and the database context.
- **Web**: Contains the ASP.NET Core MVC layer, including controllers, views, and models.

---


---

Once you upload the images to the `images` folder in your GitHub repository, simply update the image URLs in the markdown with the actual image URLs to showcase the screenshots in the README.
