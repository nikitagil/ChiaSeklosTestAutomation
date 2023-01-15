# ChiaSeklosTestAutomation

URL - https://chiaseklos.lt/parduotuve/

Resolution - 800x600

### **Scenario 1: Search**

##### *Case 1: Go To Item Page By Using Search*

- ###### Click Burger Menu
- ###### Click Search Field
- ###### Type “aguonos”
- ###### Click on item that appeared in search list
- ###### Verify that URL path matches with item name that was used during search

##### *Case 2: Search Invalid Product* 
- ###### Click Burger Menu
- ###### Click Search Field
- ###### Type “hello”
- ###### Verify that “Produktų nerasta.” appears as search result
- ###### Click on search icon
- ###### Verify that “Produktų nerasta.” appears as search result on current page as well

### **Scenario 2: Wishlist**

##### *Case 1: Add Item Wishlist and remove it*
- ###### Hover to “Agar” product 
- ###### Click Heart Icon
- ###### Verify the message that pops up says "Produktas pridėtas!"
- ###### Click “Žiūrėti norų sąrašą”
- ###### Click cross icon next to product
- ###### Verify the text that appears says “Product successfully removed.”

### **Scenario 3: Shopping Basket**

##### *Case 1: Add Item to Shopping Basket*
- ###### Hover to “Ašvaganda (Ashwagandha) milteliai” product
- ###### Click “Greita peržiūra”
- ###### Click “Į Krepšelį” button
- ###### Verify the alert that pops up says "Pasirinkite produkto savybes prieš pridėdami šį produktą į savo krepšelį."
- ###### Click “OK” button
- ###### Click “100g” button
- ###### Click “+” button
- ###### Click “Į Krepšelį” button
- ###### Verify the message that appears at the top of the page says "2 × “Ašvaganda (Ashwagandha) milteliai” - įdėti į krepšelį".

##### *Case 2: Remove Item From Basket Using Basket Slide Menu*
- ###### Hover to “Anakardžių riešutai skrudinti meduje” product
- ###### Click “Greita peržiūra”
- ###### Click “450g” button
- ###### Click quantity input field
- ###### Press Backspace
- ###### Type “8”
- ###### Click “Į Krepšelį” button
- ###### Click Basket icon
- ###### Click cross icon next to product
- ###### Verify the text that appears says "Krepšelyje nėra produktų."
