# Haku
A library to create Visual Novel in terminal

Exemple (F#):
```fs
// Print and things
Haku.text.clear() // Clear the terminal
Haku.text.dialogue("Text you want to show\n", 50 (*Interval between each character*), false (*Add a newline (\n)*), true (*Tell the interval should be randomized*))
// Inputs
Haku.input.setPrompt("> ") // set the prompt for inputs
Hake.input.getPrompt() // get the prompt
Haku.input.get() // Read input
```
**More things will be added later**
