# Recipe Manager WPF Application

## Overview

This is a simple **Recipe Manager** desktop application built with **WPF (Windows Presentation Foundation)** in C#. The app allows users to input, manage, and display multiple recipes along with their ingredients, quantities, measurements, food groups, calories, and preparation steps.

---

## Features

- Input multiple recipes and their ingredients
- Store recipe data including ingredient details and cooking steps
- Display all recipes with nutritional information (total calories)
- Search recipes by name
- Filter ingredients by name or food group
- Scale ingredient quantities (×2, ÷2, ×3) and reset scaling
- Identify ingredient with the highest calorie count
- Reset the application to enter new recipes

---

## How to Use

1. Enter the number of recipes and ingredients.
2. Input each recipe name.
3. For each recipe, enter all ingredient details including quantity, measurement, food group, and calories.
4. Enter preparation steps for each recipe.
5. Use the buttons to print, search, filter, scale ingredients, or reset the data.

---

## Technologies Used

- C# with .NET (WPF)
- Visual Studio for development
- Collections: `ArrayList`, `List<T>`, `SortedList`

---

## Limitations

- No data persistence — all data is lost when the application is closed.
- Basic UI with manual visibility toggling.
- Minimal error handling.
- No database or file storage integration.

---

## Future Improvements

- Add file or database storage for persistence.
- Improve UI/UX with better controls and layout.
- Implement MVVM pattern for cleaner architecture.
- Add validation and error feedback.
- Support editing and deleting recipes and ingredients.

---

## Author

Created by Sibusiso Mathebula

---

## License

This project is open source and available under the MIT License.

