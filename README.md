# PianoPlayer  
*A simple C# console application that plays musical note sequences and simulates a basic piano engine.*

## Overview  
**PianoPlayer** is a lightweight C# project designed to demonstrate core programming concepts such as object-oriented design, input parsing, and basic audio or console-based note playback.  
It can play predefined songs or user-entered note sequences and serves as a clean example of C# fundamentals in action.

---

## Features  
- Play predefined songs  
- Input and play custom note sequences  
- Structured Note and Song classes  
- Adjustable tempo (if enabled in your version)  
- Looping playback (optional)  
- Extensible design - easy to add new songs or features  

---

## Project Structure  
```
PianoPlayer/
  Program.cs                # Main entry point
  Models/
       Note.cs             # Represents musical notes
       Song.cs             # Represents a sequence of notes
  Services/
       PianoEngine.cs      # Core logic for playing notes and songs
  Utils/
       NoteParser.cs       # Converts string input into Note objects
```

---

## Technologies Used  
- **C#**  
- **.NET Console Application**  
- **System.Console.Beep** or any other playback method implemented  

---

## Running the Project  
### Option 1: Using Visual Studio / Rider  
1. Clone the repository  
2. Open the solution  
3. Run the project  

### Option 2: Using the .NET CLI  
```bash
git clone https://github.com/serbancaia/PianoPlayer.git
cd PianoPlayer
dotnet build
dotnet run
```

---

## Example Usage  
**Input:**  
```
C4 D4 E4 F4 G4 G4
```

**Console Output:**  
```
Playing C4
Playing D4
Playing E4
...
```

(Sound is played if using Console.Beep or a similar audio method.)

---

## Future Improvements  
- MIDI playback  
- GUI version (WinForms/WPF)  
- Real audio samples  
- Save/load custom songs  
- Metronome or tempo slider  

---

## Purpose of This Project  
This project was built to practice and demonstrate:  
- Object-oriented programming  
- Class design and separation of concerns  
- Parsing structured text input  
- Basic sound generation  
- Writing a functional C# console application  

It is also included in my portfolio to showcase my ability to create clear, maintainable C# code.

---

## License  
This project is released under the MIT License.
