1.Application description: 
	This application is a console program in C# that validates a user-inputted string based on certain criteria.
	After asking the user to input a string and a maximum allowed string length (as an integer), it validates this input using the IsValid method from the _validationService.
	If the string satisfiesconditions, the console outputs "Your string is valid"; otherwise, it displays "Your inputs are invalid."
	
2.Regex implementation description:
	
	The regular expression, or pattern, breaks down as follows:

	^ asserts the start of the line.

	(?=.*[a-z]) is a positive lookahead, checking for at least one lowercase letter from a to z.

	(?=.*[A-Z]) is another positive lookahead, checking for at least one uppercase letter from A to Z.

	(?=.*\d) checks for at least one digit.

	(?=.*[!"#$%&'()*+,-./:;<=>?@[\]^_{|}~])` checks for at least one of the provided special characters.

	[A-Za-z\d!"#$%&'()*+,-./:;<=>?@[\]^_{|}~]{1,+maxLength+}$ensures that the entire string only consists of the previously defined characters (uppercase and lowercase letters, digits, special characters) and its length is between 1 and the maximum length defined by the user.$` asserts the end of the line.

	The Regex.IsMatch(input) method then tests whether the input string matches this pattern. If it does, the function returns true indicating the input is valid according to the given conditions. If it doesn't, the function returns false, indicating the input string is invalid.

3.Information on how to run the developed application locally.
	If you have the solution downloaded and you have Visual Studio installed, you can follow these steps to run the program:

	Open Visual Studio.

	Go to File -> Open -> Project/Solution or simply press Ctrl + Shift + O.

	Navigate to the location where you have the solution file (.sln) downloaded and open it.

	After the solution has loaded, you can see your project and all its files in the Solution Explorer. If you don't see the Solution Explorer, go to View -> Solution Explorer or press Ctrl + Alt + L.

	Open the Program.cs file or whichever file that contains your Main method by double-clicking on it in the Solution Explorer.

	Now that you have the program open, you can run it by pressing F5 or by clicking on the green "Start Debugging" arrow in the toolbar at the top.

	A console window will open and you will be prompted to enter a string and the maximum allowed string length, as specified in your program.

	Remember, any changes you make to the code will be automatically saved when you start debugging (run the program). But you can also manually save at any time by pressing Ctrl + S or going to File -> Save All.
