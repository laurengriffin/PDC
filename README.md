
# PDC

This is a Windows Forms application that provides a simple interface that allows users to read/write to a PLC and/or a SQL Database.

This project uses the libplctag library, which can be found [here](https://github.com/kyle-github/libplctag) and the c# wrapper for this library can be found [here](https://github.com/mesta1/libplctag-csharp).

## Development + Installation
### Using Visual Studio
*If you do not have visual studio downloaded onto your computer, you can download it [here](https://www.visualstudio.com/downloads/).*

1. Download the repository
2. Open `PDC_Lauren.sln` as a solution in Visual Studio
3. Add the corresponding reference(s)

*This is all you need to do to start developing. In order to build the program and run it on other computers, you can follow the steps listed below.*
## Build + Release
### Using Visual Basic
#### Debug Version
1. To run the program with debug mode, simply hit the `F5` key.
#### Release Version
1. Build a 'release' version (no debug) of application
2. Run the application using`PDC.exe`.

## Use Guide
When you start the application, this window should open:

![](https://lh3.googleusercontent.com/ZSmGV1kPpbXzaP9Gk042jyOEX8w4uBjIaNW2csbvweOVTxRkNRMIYy5GgtHGOgRJgxLbqPhn7tRH)

*From here you can decide if you want to communicate to a PLC or a SQL Database. Use the tabs on the top left of the form to make a selection.
___
### PLC Communication
*To read or write to the PLC you need to fill out the fields in the form. Below are descriptions for each field.*

![](https://lh3.googleusercontent.com/ZSmGV1kPpbXzaP9Gk042jyOEX8w4uBjIaNW2csbvweOVTxRkNRMIYy5GgtHGOgRJgxLbqPhn7tRH)

**IP Address:** The IP Address of the PLC.
**Path:** The path to access the PLC from the gateway. The path is required for an LGX cpu but optional for other types.
**Slot:** The slot is a continuation of the path. For example if the PLC is located on the Backplane on slot 0, you would choose 'Backplane' for Path and '0' for Slot.
**Cpu Type:** Type of PLC. This library supports: compactlogix, clgx, lgx, controllogix, flexlogix, and flgx.
**Tag Name:** The name of the tag to access. 
- If the tag is located inside of another tag: `OutsideTag.InnerTag`
- If the tag is an array: `myTag[3]` 

**Data Type:** The type of data the tag is storing. This library supports: Int8, Int16, Int32, Float32, and String.
**Element Count:** *(optional)* The number of elements in array.
![](https://lh3.googleusercontent.com/oqgUHTHUudL6SgmBaLaAYUZ_Pb2Uh0_pXyc_xAqY3fRaYFatVtdYetWiMQe2MWlVAGTJRehj4vVN)
**Write to PLC:** Select this checkbox to write to the PLC instead of reading from the PLC.
**Value to Write:** When 'Write to PLC' is selected, a textbox to enter the value to write to the PLC appears. This value should match the format of the Data Type that was selected.

Once the fields are filled in, click the 'Connect' button to get the results.
___
### SQL Database Communication
*To read or write to the SQL Database you need to fill out the fields in the form. Below are descriptions for each field.*

![](https://lh3.googleusercontent.com/MXe1WxCp8yrBtCFNYkN1RIUlYCeCEKZrNNEa0NKCTcNsgYP-ilPdeJL5cOB6D75vJmca7xAnyHl6)

**Server Name:** The server that the SQL Database is located on.
**Database Name:** The name of the database to access.
**Username:** The username of the login credentials to access the database.
**Password:** The password of the login credentials to access the database.

Once the fields are filled in, click the 'Load' button to reveal a drop-down list of tables within the database. 

![](https://lh3.googleusercontent.com/8ZUz1xYVMoGqFZTnthHAbRhcJvpBKCAgySoCgC3qNeI1oqtzRb3nDsmKMIRaotEP_rSwsWJM_e0E)

Choose a table to view/edit, then click the 'View' button to view the table. A new form will pop up that displays all of the records in the selected table. 

![](https://lh3.googleusercontent.com/iy4C-sIPDlqq2279vbAj-mk_F8ZJEgARDtkynePjepNVlANNsrm3ffiugDKXK9vatuV_yPblGhz2)

In order to edit the data, simply click in the desired cell, modify the data, and click 'Save'.

*Note: primary keys are not editable.*


