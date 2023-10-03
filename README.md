# c-net-area-calc
## Rectangle Area & Perimeter Calculator - C#.NET WinForms Application

### Description:

This is a Windows Forms application built using C#.NET, intended to calculate the area and perimeter of a rectangle based on the provided length and width values.

### Objectives:

1. **User Input**: Allow users to input:
   - Length of the rectangle
   - Width of the rectangle

2. **Calculation**:
   - Compute the area of the rectangle: \( \text{Area} = \text{Length} \times \text{Width} \)
   - Compute the perimeter of the rectangle: \( \text{Perimeter} = 2 \times (\text{Length} + \text{Width}) \)
   - Display the results in a user-friendly format, rounded to two decimal places.

3. **User Experience Enhancements**:
   - Pressing 'Enter' triggers the calculation, mimicking a submit behavior.
   - Pressing 'Esc' will close the application.

4. **Error Handling**:
   - Employ a try-catch block to handle any unexpected errors during computation or conversion. Provide the user with an informative error message if such a situation arises.

### How it's achieved:

1. **Windows Forms Controls**: Utilized text boxes for length and width input, buttons for triggering calculations and exiting the application, and additional text boxes to display the computed area and perimeter.

2. **Event-Driven Programming**: Made use of click event handlers for the calculate (`btnCalculate_Click`) and exit (`btnExit_Click`) functionalities.

3. **Converting and Calculating**: Converted user inputs from string to decimal data types. Then, straightforward multiplication operations are used to compute the area and perimeter of the rectangle.

4. **Formatting Results**: The computed area and perimeter are formatted to two decimal places using the `"n2"` string format.

5. **Focus Management**: After computation, the focus is shifted back to the length input for a seamless user experience, facilitating easy modifications and recalculation.

6. **Enhanced Button Behavior**: 
   - The `AcceptButton` property of the form is set to the calculate button, enabling the 'Enter' key to execute its click event.
   - Similarly, the `CancelButton` property is associated with the exit button, allowing the 'Esc' key to trigger the application to close.

7. **Error Handling**: An encompassing try-catch block is used to catch any general exceptions. Upon catching an exception, a MessageBox informs the user of the error.

### Conclusion:

This application demonstrates a straightforward and practical use case of geometry calculations using a C#.NET Windows Forms interface. It embodies fundamental principles like user input validation, event-driven programming, and mathematical operations, all while ensuring a smooth and intuitive user experience.
