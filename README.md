# ChiaSeklosTestAutomation

URL - https://chiaseklos.lt/parduotuve/

Resolution - 800x600

### **Scenario 1: Search**

##### *Case 1: Go To Item Page By Using Search*

1. ###### Click Burger Menu
2. ###### Click Search Field
3. ###### Type “aguonos”
4. ###### Click on item that appeared in search list
5. ###### Verify that URL path matches with item name that was used during search

##### *Case 2: Search Invalid Product* 
1. ###### Click Burger Menu
2. ###### Click Search Field
3. ###### Type “hello”
4. ###### Verify that “Produktų nerasta.” appears as search result
5. ###### Click on search icon
6. ###### Verify that “Produktų nerasta.” appears as search result on current page as well

### **Scenario 2: Wishlist**

##### *Case 1: Add Item Wishlist and remove it*
1. ###### Hover to “Agar agaras” product 
2. ###### Click Heart Icon
3. ###### Verify the message that pops up says "Produktas pridėtas!"
4. ###### Click “Žiūrėti norų sąrašą”
5. ###### Click cross icon next to product
6. ###### Verify the text that appears says “Product successfully removed.”

### **Scenario 3: Shopping Basket**

##### *Case 1: Add Item to Shopping Basket*
1. ###### Scroll down to the bottom of product list
2. ###### Hover to “Ašvaganda (Ashwagandha) milteliai” product
3. ###### Click “Greita peržiūra”
4. ###### Click “Į Krepšelį” button
5. ###### Verify the alert that pops up says "Pasirinkite produkto savybes prieš pridėdami šį produktą į savo krepšelį."
6. ###### Click “OK” button
7. ###### Click “100g” button
8. ###### Click “+” button
9. ###### Click “Į Krepšelį” button
10. ###### Verify the message that appears at the top of the page says "2 × “Ašvaganda (Ashwagandha) milteliai” - įdėti į krepšelį".

##### *Case 2: Remove Item From Basket Using Basket Slide Menu*
1. ###### Scroll down to the bottom of product list
2. ###### Hover to “Anakardžių riešutai skrudinti meduje” product
3. ###### Click “Greita peržiūra”
4. ###### Click “450g” button
5. ###### Click quantity input field (after "1")
6. ###### Press Backspace
7. ###### Type “8”
8. ###### Click “Į Krepšelį” button
9. ###### Click Basket icon
10. ###### Click cross icon next to product
11. ###### Verify the text that appears says "Krepšelyje nėra produktų."
