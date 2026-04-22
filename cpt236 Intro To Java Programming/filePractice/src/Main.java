import java.io.*;
import java.nio.file.*;
import java.util.Scanner;

    static void main(String[] args)
    {
        // create scanner for user input
        Scanner input = new Scanner(System.in);

        // path to file (will create if it does not exist)
        Path file = Paths.get("studentRecords.txt");

        // call write method first
        writeStudents(file, input);

        // then read what we just wrote
        readStudents(file);
    }

    // ============================
    // method to WRITE to file
    // ============================
    public static void writeStudents(Path file, Scanner input)
    {
        String name;
        String id;
        String record;
        String delimiter = "#";

        try
        {
            // open output stream (create file if needed)
            OutputStream output = new BufferedOutputStream(
                    Files.newOutputStream(file, StandardOpenOption.CREATE)
            );

            // writer to write text
            BufferedWriter writer = new BufferedWriter(new OutputStreamWriter(output));

            // ask for first name
            System.out.print("enter student name (or QUIT to stop)>> ");
            name = input.nextLine();

            // loop until user types QUIT
            while (!name.equalsIgnoreCase("QUIT"))
            {
                System.out.print("enter student id>> ");
                id = input.nextLine();

                // build record like: name#id
                record = name + delimiter + id;

                // write to file
                writer.write(record);

                // move to next line
                writer.newLine();

                // ask again
                System.out.print("enter student name (or QUIT to stop)>> ");
                name = input.nextLine();
            }

            // always close writer
            writer.close();
        }
        catch (IOException e)
        {
            System.out.println("error writing file");
        }
    }

    // ============================
    // method to READ from file
    // ============================
    public static void readStudents(Path file)
    {
        String line;
        String delimiter = "#";

        try
        {
            // open input stream
            InputStream input = new BufferedInputStream(
                    Files.newInputStream(file)
            );

            // reader to read text
            BufferedReader reader = new BufferedReader(new InputStreamReader(input));

            System.out.println("\n--- student records ---");

            // read each line until end of file
            while ((line = reader.readLine()) != null)
            {
                // split line into parts using #
                String[] parts = line.split(delimiter);

                // parts[0] = name, parts[1] = id
                System.out.println("name: " + parts[0]);
                System.out.println("id: " + parts[1]);
                System.out.println("-------------------");
            }

            // close reader
            reader.close();
        }
        catch (IOException e)
        {
            System.out.println("error reading file");
        }
    }
