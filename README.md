# Unexpected behavior when swapping mutable references in F#

This repository demonstrates an unexpected behavior when swapping mutable references in F#.  When attempting to swap mutable references using a simple swap function, the references themselves are swapped, but the values they point to remain unchanged.

The issue is highlighted in the `bug.fs` file. The `bugSolution.fs` file provides a corrected implementation.

## How to reproduce

1. Clone this repository.
2. Open the `bug.fs` file in an F# editor (e.g., Visual Studio, Ionide).
3. Run the code. Observe that the values pointed to by the references do not swap correctly.
4. Open the `bugSolution.fs` file and observe the corrected implementation.

## Solution

The solution involves directly manipulating the values held by the references rather than swapping the references themselves. This is demonstrated in the `bugSolution.fs` file.