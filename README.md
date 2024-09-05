EasyLLM V2

EasyLLM is an application designed to streamline the management and usage of tracked materials in a production environment. It allows administrators to easily track material quantities and usage history, and allows users to easily copy material information to the clipboard for pasting into work order management software.
The application also supports multiple material types, as defined below:

Program Stock:
  - Program Stock materials are precisely tracked in order to accurately issue the correct quantites to Shop Orders. These materials are visible to all users. Upon use, users are prompted to input the number of units used, and the Shop Order.
  - Administrators can specify the quantity to deduct from the remaning quantity for each material. 

User Stock:
  - User Stock materials are individually Checked-Out to users for use on all work. Users are to store these materials at their workstation. These materials are not tracked as precisely as Program Stock.

Common Stock
  - Common Stock materials are the least tracked materials. These materials are visible to all users and can be used at will for any work. Users do not check these materials out and are not asked to specify quantity.


EasyLLM relies on SQLite, an open-source, public domain, embedded SQL database engine.
EasyLLM includes ZXing, an open-source barcode image generation/processing library.
EasyLLM also includes interoperability for Microsoft Ofice Excel using libraries generated and signed by Microsoft.

EasyLLM is designed for use at BAE Systems, Space and Mission Systems (fka Ball Aerospace & Technologies).
