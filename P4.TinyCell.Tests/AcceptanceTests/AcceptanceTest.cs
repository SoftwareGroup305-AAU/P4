namespace P4.TinyCell.Tests;

public class AcceptanceTest
{
    // Step 1) Compile the P4.TinyCell project.
    // Step 2) There's already a reference to the P4.TinyCell project in the P4.TinyCell.Tests project, now we need to simulate a cli usage of the compiler.
    // Step 3) Create a Test.tc file in TinyCell language with the following code:
    /*
        dpin ledPin = 13;

        setup {
            set ledPin to OUTPUT;
        }

        update {
            write HIGH to ledPin;
            delay(1000);
            write LOW to ledPin;
            delay(1000);
        }
    */
    // Step 4) Use the compiled P4.TinyCell executable to compile a simple program, in this case "Test.tc".
    // Step 5) Assert that an Arduino folder is created with the transpiled ino file.
    // Step 6) Assert that the ino file contains the expected output code.
    // Step 7) Use the Arduino CLI to compile the ino file with user defined flags. 
    // Step 8) Assert that the compilation was successful.
    // Step 9) Use the Arduino CLI to upload the ino file to a connected Arduino board.
    // Step 10) Assert that the upload was successful.
    // Step 11) Use the Arduino CLI to monitor the serial output of the Arduino board.
    // Step 12) Assert that the serial output matches the expected output.


}
