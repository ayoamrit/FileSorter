# FileSorter
Effortlessly manages your Windows downloads by automatically categorizing and sorting files based on their types into dedicated folders, optimizing your organizational workflow.

## Overview
FileSorter is an unobtrusive background application designed to streamline file organization in a specified download folder. The application monitors the download folder at regular intervals, identifying newly added files and categorizing them into respective extension folders. If a folder corresponding to the file's extension doesn't exist, FileSorter dynamically creates one before moving the file. Leveraging a multithreading approach and optimizing memory usage by removing files from the monitoring list after processing, FileSorter provides an efficient solution for maintaining a well-organized file structure.

## Features

- **Automated File Organization**: FileSorter continuously monitors the download folder and automatically organizes newly added files based on their extensions.
- **Dynamic Folder Creation**: The application dynamically creates folders corresponding to file extensions, ensuring seamless organization.
- **Multithreading Efficiency**: Utilizes a multithreading approach for improved efficiency and responsiveness.
- **Memory Optimization**: Optimizes memory usage by removing processed files from the monitoring list.
- **Exception Handling**: Every potential exception that could cause an error is handled, ensuring a robust and reliable application.

## Installation

1. Clone the repository:

   ```bash
   git clone https://github.com/ayoamrit/FileSorter.git

2. Navigate to the project directory:

   ```bash
   cd FIleSorter

3. Locate the .exe file:

   ```bash
   cd FIleSorter\FIleSorter\bin\Debug\net6.0

4. Run FileSorter:

   ```bash
   FileSorter

## Usage
1. Run FileSorter.
2. The program will begin monitoring the specified download folder.
3. Newly added files will be automatically organized into their respective extension folders.

## Contributing
Contributions are encouraged! If you encounter a bug or have an enhancement in mind, please open an issue or submit a pull request.

## Acknowledgments
- Inspired by the need for an efficient file organization solution.
- Gratitude to the .NET Core community for providing robust development tools.
