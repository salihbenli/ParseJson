# ParseJson

## Overview

ParseJson is a simple C# console application that demonstrates how to read a JSON file, parse its content, and display specific data. The application reads a JSON file containing receipt data and prints each line of the receipt description to the console.

## Project Structure

    JsonParseExample/
    ├── Program.cs
    ├── ParseJson/
    │   └── Models/
    │       ├── ReceiptData.cs
    │       └── DescriptionItem.cs
    ├── response.json
    ├── JsonParseExample.csproj
    └── README.md

- Program.cs: The main entry point of the application. It reads the JSON file and prints the receipt description.
- ParseJson/Models/ReceiptData.cs: Defines the ReceiptData class, which represents the structure of the JSON data.
- ParseJson/Models/DescriptionItem.cs: Defines the DescriptionItem class, which represents each item in the receipt description.
- response.json: The JSON file containing the receipt data to be parsed.
- JsonParseExample.csproj: The project file that defines the C# project.
- README.md: This file, providing an overview of the project.






## Usage

### Prerequisites

- .NET SDK installed on your machine.
- Newtonsoft.Json package for JSON parsing

### Running the Project

1. Clone the repository or download the source code.
2. Open a terminal/command prompt and navigate to the project directory.
3. Compile and run the project using the following command:
   ```sh
   dotnet run
## Code Explanation
The project contains a single class with the following methods:

1. Main(): Runs and the desired json output is obtained.

