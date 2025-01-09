using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionWork
{
    internal class FileInputOutput
    {
        //Write a program that merges the contents of two files(file1.txt and file2.txt) into a
        //third file(merged.txt). 
        public static void MergeTxtFiles()
        {
            string path1 = @"C:\Users\Piyush\Desktop\C# Programs\SessionWork\file1.txt";
            string path2 = @"C:\Users\Piyush\Desktop\C# Programs\SessionWork\file2.txt";
            string mergedPath = @"C:\Users\Piyush\Desktop\C# Programs\SessionWork\merged.txt";

            try
            {
                if (!File.Exists(path1))
                {
                    File.WriteAllText(path1, "Hello \n");
                    Console.WriteLine("File 1 created and content added!");
                }
                else
                {
                    Console.WriteLine("File 1 already exists");
                }

                if (!File.Exists(path2))
                {
                    File.WriteAllText(path2, "World! \n");
                    Console.WriteLine("File 2 created and content added!");
                }
                else
                {
                    Console.WriteLine("File 2 already exists");
                }

                // Merge the contents into merged.txt
                File.WriteAllText(mergedPath, File.ReadAllText(path1));
                File.AppendAllText(mergedPath, File.ReadAllText(path2));

                Console.WriteLine("Contents of file1.txt and file2.txt merged into merged.txt successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        /*Create a program that manages student records, including reading and writing student data
         * to and from a text file(students.txt). Include functionality to add, delete,
         * and update student records.*/
        public static void StudentRecords()
        {
            string path1 = @"C:\Users\Piyush\Desktop\C# Programs\SessionWork\students.txt";

            if (!File.Exists(path1))
            {
                File.Create(path1).Close();
                Console.WriteLine("Student file created!");
            }
            else
            {
                Console.WriteLine("Student file already exists!");
            }

            while (true)
            {
                Console.WriteLine("1. Add Student\n2. View All Students\n3. Update Student\n4. Delete Student\n5. Exit\nEnter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddStudent(path1);
                        break;
                    case "2":
                        ViewStudents(path1);
                        break;
                    case "3":
                        UpdateStudent(path1);
                        break;
                    case "4":
                        DeleteStudent(path1);
                        break;
                    case "5":
                        Console.WriteLine("Exiting program...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
        public static void AddStudent(string path)
        {
            Console.Write("Enter student ID: ");
            string id = Console.ReadLine();

            Console.Write("Enter student name: ");
            string name = Console.ReadLine();

            string student = id + "," + name;

            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine(student);
            }

            Console.WriteLine("Student record added successfully!");
        }

        public static void ViewStudents(string path)
        {
            string[] students = File.ReadAllLines(path);

            if (students.Length == 0)
            {
                Console.WriteLine("No student records found.");
            }
            else
            {
                Console.WriteLine("\nStudent Records:");
                foreach (string student in students)
                {
                    string[] parts = student.Split(',');
                    Console.WriteLine("ID: " + parts[0] + ", Name: " + parts[1]);
                }
            }
        }

        public static void UpdateStudent(string path)
        {
            Console.Write("Enter the ID of the student to update: ");
            string id = Console.ReadLine();

            string[] s = File.ReadAllLines(path);
            bool found = false;

            for (int i = 0; i < s.Length; i++)
            {
                string[] parts = s[i].Split(',');
                if (parts[0] == id)
                {
                    Console.Write("Enter new name for the student: ");
                    string newName = Console.ReadLine();

                    s[i] = parts[0] + "," + newName;
                    found = true;
                    break;
                }
            }

            if (found)
            {
                File.WriteAllLines(path, s);
                Console.WriteLine("Student record updated successfully!");
            }
            else
            {
                Console.WriteLine("Student ID not found.");
            }
        }

        public static void DeleteStudent(string path)
        {
            Console.Write("Enter the ID of the student to delete: ");
            string id = Console.ReadLine();

            string[] s = File.ReadAllLines(path);
            bool found = false;

            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach (string student in s)
                {
                    string[] parts = student.Split(',');
                    if (parts[0] != id)
                    {
                        writer.WriteLine(student);
                        //Only matching record will be added 
                    }
                    else
                    {
                        found = true;
                        //if not matched then deleted
                    }
                }
            }

            if (found)
            {
                Console.WriteLine("Student record deleted successfully!");
            }
            else
            {
                Console.WriteLine("Student ID not found.");
            }
        }


        /*
         * Create a simple text editor that allows users to open, edit, and save text files.
         * Include basic features like find and replace text. 
         * NOTE: Everytime the chnages are made make sure to Save the file
         * */
        public static void TextEditor()
        {
            string path = @"C:\Users\Piyush\Desktop\C# Programs\SessionWork\TextEditorFile.txt";
            string fileContent = "";

            if (!File.Exists(path))
            {
                File.Create(path).Close();
                Console.WriteLine("Text file created!");
            }
            else
            {
                Console.WriteLine("Text file already exists!");
            }

            while (true)
            {
                Console.WriteLine("\nEnter your choice:\n1. Open file\n2. Edit file\n3. Save file\n4. Find and replace text\n5. Exit!");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": // Open and display the file content
                        fileContent = File.ReadAllText(path);
                        Console.WriteLine("\nFile content:\n" + fileContent);
                        break;

                    case "2": // Edit specific part of the content (add new content)
                        try
                        {
                            Console.WriteLine("\nCurrent content of the file:\n");
                            Console.WriteLine(fileContent);  // Display the existing content

                            Console.WriteLine("\nEnter the text you want to add (it will be appended):");
                            string newText = Console.ReadLine();

                            // Append the new text to the existing content without adding a newline
                            fileContent += newText;

                            Console.WriteLine("\nText after editing (new content added):");
                            Console.WriteLine(fileContent); // Show updated content
                        }
                        catch (ArgumentException e)
                        {
                            Console.WriteLine("Error: " + e.Message);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Error: " + e.Message);
                        }
                        break;

                    case "3": // Save the current content to the file
                        File.WriteAllText(path, fileContent);
                        Console.WriteLine("\nFile saved successfully.");
                        break;

                    case "4": // Find and replace text in the current content
                        Console.Write("\nEnter the text to find: ");
                        string findText = Console.ReadLine();
                        Console.Write("Enter the text to replace with: ");
                        string replaceText = Console.ReadLine();

                        if (!string.IsNullOrEmpty(fileContent))
                        {
                            if (fileContent.Contains(findText))
                            {
                                fileContent = fileContent.Replace(findText, replaceText);
                                Console.WriteLine("\nText replaced successfully.");
                            }
                            else
                            {
                                Console.WriteLine("\nText to find not found in the file content.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nFile content is empty. Load or edit the file first.");
                        }
                        break;

                    case "5": // Exit the program
                        Console.WriteLine("\nExiting...");
                        return;

                    default: // Handle invalid input
                        Console.WriteLine("\nInvalid choice. Please try again.");
                        break;
                }
            }
        }

    }
}
