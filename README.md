
# CPU Scheduling Simulation: Priority Strategy

This project is part of a university assignment and involves developing a software system that simulates the behavior of a CPU scheduling module using the **Priority Scheduling Strategy**.

## Features Implemented

### Essential Data Structures
- **Ready Queue**: A structure that stores processes waiting to be scheduled for execution, organized by priority.

### Core Operations
- **Load**: Inserts a process into the ready queue based on its priority level. Processes with higher priority are placed closer to the front of the queue.
- **Dispatch**: Selects the highest-priority process from the ready queue and assigns it to the CPU for execution.
- **Finish**: Marks a process as complete, removes it from the CPU, and updates the ready queue.
- **Show**: Displays the current state of the ready queue and any processes being executed or waiting.

## Implementation Highlights
- **Priority-Based Scheduling**: Processes are assigned a priority value. The scheduler ensures that higher-priority processes are executed before lower-priority ones.
- **Efficient Queue Management**: The ready queue is dynamically updated to reflect changes in process status, such as loading, dispatching, and finishing.
- **Real-World Simulation**: The program closely mirrors real CPU scheduling scenarios, making it an excellent tool for educational and experimental purposes.

## How to Run
- The program accepts input for process attributes such as ID, priority, and required execution time.
- Commands like `Load`, `Dispatch`, `Finish`, and `Show` can be issued to interact with the scheduling system.
- The system outputs the current state after each operation, demonstrating the behavior of a priority-based CPU scheduler.

## Educational Context
This project was developed as part of a university assignment to deepen understanding of operating system concepts, particularly CPU scheduling. It provides a hands-on approach to learning how priority scheduling works and how operating systems manage tasks efficiently.

## Screenshots

Below are some screenshots of the project in action:

<p align="center">
  <img src="Images\OS_img01.png" alt="Screenshot 1" width="45%">
  <img src="Images\OS_img02.png" alt="Screenshot 2" width="45%">
</p>
<p align="center">
  <img src="Images\OS_img03.png" alt="Screenshot 3" width="45%">
  <img src="Images\OS_img04.png" alt="Screenshot 4" width="45%">
</p>
<p align="center">
  <img src="Images\OS_img05.png" alt="Screenshot 5" width="45%">
  <img src="Images\OS_img06.png" alt="Screenshot 6" width="45%">
</p>

