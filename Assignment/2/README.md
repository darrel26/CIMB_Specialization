# Offices Database

### Dalam folder Assignment/2 harus terdapat 3 file ini

- **_bank_ddl.sql_** - Pembuatan database dan table
- **_bank_dml.sql_** - Penambahan data untuk tiap table
- **_bank_select_relation.sql_** - Select query untuk menampilkan relasi antar tabel

## Preview

### SQL Query untuk :

1. Menampilkan semua data customers
   <br>

   ```sql
   SELECT * FROM `customers`
   ```

   | customerNumber | customerName       | contactLastName | contactFirstName | phone           | addressLine1                 | addressLine2 | city     | state | postalCode | country   | salesRepEmployeeNumber | creditLimit |
   | -------------- | ------------------ | --------------- | ---------------- | --------------- | ---------------------------- | ------------ | -------- | ----- | ---------- | --------- | ---------------------- | ----------- |
   | 12001          | PT Nusantara Jaya  | Wijaya          | Agung            | +62 21 88888888 | Jl. Merdeka Raya No. 10      |              | Jakarta  | JK    | 10450      | Indonesia | 1002                   | 500000.00   |
   | 12002          | PT Abadi Sentosa   | Susilowati      | Ratna            | +62 22 77777777 | Jl. Braga No. 25             |              | Bandung  | JB    | 40114      | Indonesia | 1004                   | 250000.00   |
   | 12003          | CV Surya Kencana   | Putra           | Bambang          | +62 31 66666666 | Jl. Panglima Sudirman No. 50 |              | Surabaya | JI    | 60251      | Indonesia | 1006                   | 100000.00   |
   | 12004          | Toko Merpati Putih | Prasetyo        | Eko              | +62 61 55555555 | Jl. Gatot Subroto No. 12     |              | Medan    | SU    | 20153      | Indonesia | 1001                   | 75000.00    |
   | 12005          | UD Bintang Timur   | Lestari         | Ayu              | +62 24 44444444 | Jl. Pahlawan No. 8           |              | Semarang | JT    | 50135      | Indonesia | 1005                   | 35000.00    |
   | 12006          | CV Bunga Indah     | Hidayat         | Rahmat           | +62 361 9999999 | Jl. Kuta Raya No. 15         |              | Denpasar | BA    | 80361      | Indonesia | 1003                   | 150000.00   |

2. Menampilkan semua data offices
   <br>

   ```sql
   SELECT * FROM `offices`
   ```

   | officeCode | city     | phone           | addressLine1                 | addressLine2        | state          | country   | postalCode | territory        |
   | ---------- | -------- | --------------- | ---------------------------- | ------------------- | -------------- | --------- | ---------- | ---------------- |
   | BDG015     | Bandung  | +62 22 4444444  | Jl. Asia Afrika No. 111      | Bandung City Center | West Java      | Indonesia | 40111      | Priangan         |
   | DPS091     | Denpasar | +62 361 8888888 | Jl. Raya Puputan No. 77      | Renon               | Bali           | Indonesia | 80234      | Bali             |
   | JKT001     | Jakarta  | +62 21 5555555  | Jl. M.H. Thamrin No. 1       | Central Jakarta     | DKI Jakarta    | Indonesia | 10350      | Jakarta Raya     |
   | MDN049     | Medan    | +62 61 2222222  | Jl. Pemuda No. 55            | Medan Maimun        | North Sumatra  | Indonesia | 20151      | Sumatra Utara    |
   | MKS115     | Makassar | +62 411 7777777 | Jl. Jenderal Sudirman No. 66 | Maricaya Baru       | South Sulawesi | Indonesia | 90145      | Sulawesi Selatan |
   | SBY022     | Surabaya | +62 31 3333333  | Jl. Tunjungan No. 88         | Genteng             | East Java      | Indonesia | 60275      | East Java        |
   | SMR073     | Semarang | +62 24 1111111  | Jl. Pandanaran No. 99        | Pekunden            | Central Java   | Indonesia | 50134      | Central Java     |

3. Menampilkan semua data orderdetails
   <br>

   ```sql
   SELECT * FROM `orderdetails`
   ```

   | orderLineNumber | orderNumber | productCode | quantityOrdered | priceEach |
   | --------------- | ----------- | ----------- | --------------- | --------- |
   | 1               | 10001       | SA001       | 1               | 43.65     |
   | 2               | 10002       | MM049       | 5               | 78.08     |
   | 3               | 10003       | HE091       | 3               | 93.75     |
   | 4               | 10004       | CL022       | 3               | 89.82     |
   | 5               | 10005       | SA001       | 2               | 81.07     |
   | 6               | 10006       | SA001       | 2               | 70.14     |
   | 7               | 10006       | MM049       | 2               | 71.76     |

4. Menampilkan semua data payments
   <br>

   ```sql
   SELECT * FROM `payments`
   ```

   | customerNumber | checkNumber | paymentDate | amount  |
   | -------------- | ----------- | ----------- | ------- |
   | 12006          | CK-12007    | 2023-01-28  | 6142.62 |
   | 12001          | CK-12019    | 2024-01-11  | 6200.40 |
   | 12005          | CK-12091    | 2023-07-04  | 3229.12 |
   | 12003          | CK-12121    | 2024-01-05  | 4561.61 |
   | 12002          | CK-12221    | 2024-01-05  | 1121.40 |
   | 12004          | CK-12991    | 2024-01-02  | 7121.35 |

5. Menampilkan semua data productlines
   <br>

   ```sql
   SELECT * FROM `productlines`
   ```

   | productLine         | textDescription                                                  | htmlDescription  | image           |
   | ------------------- | ---------------------------------------------------------------- | ---------------- | --------------- |
   | Checking Accounts   | Manage your everyday spending with ease                          | checking.html    | checking.jpg    |
   | Credit Cards        | Enjoy rewards and flexibility with our credit cards              | creditcards.html | creditcards.jpg |
   | Insurance           | Protect yourself and your loved ones with our insurance products | insurance.html   | insurance.jpg   |
   | Investments         | Build your wealth with our investment options                    | investments.html | investments.jpg |
   | Loans               | Finance your dreams with our personal and business loans         | loans.html       | loans.jpg       |
   | Retirement Planning | Secure your future with our retirement planning solutions        | retirement.html  | retirement.jpg  |
   | Savings Accounts    | Grow your savings with competitive interest rates                | savings.html     | savings.jpg     |

6. Menampilkan semua data products
   <br>

   ```sql
   SELECT * FROM `products`
   ```

   | productCode | productName                       | productLine      | productScale | productVendor         | productDescription                                    | quantityInStock | buyPrice | MSRP    |
   | ----------- | --------------------------------- | ---------------- | ------------ | --------------------- | ----------------------------------------------------- | --------------- | -------- | ------- |
   | CC015       | Cash Rewards Platinum Credit Card | Credit Cards     | 1:1          | Trustworthy Financial | Earn 5% cash back on everyday purchases               | 5               | 10000.00 | 200.00  |
   | CD073       | 12-Month Certificate of Deposit   | Loans            | 1:1          | Steadfast Investments | Lock in a guaranteed interest rate                    | 10              | 5000.00  | 100.00  |
   | CL022       | Personal Loan                     | Loans            | 1:1          | Reliable Bank         | Consolidate debt or finance a major purchase          | 100             | 2500.00  | 500.00  |
   | HE091       | Home Equity Loan                  | Loans            | 1:1          | Homestead Financial   | Tap into the equity of your home for cash             | 50              | 10000.00 | 450.00  |
   | IRA115      | Traditional IRA                   | Investments      | 1:1          | FutureWise Retirement | Save for retirement with tax-deductible contributions | 75              | 25000.00 | 150.00  |
   | MM049       | Money Market Account              | Investments      | 1:1          | Secure Savings Bank   | Access your funds while earning higher interest       | 500             | 25000.00 | 50.00   |
   | SA001       | High-Yield Savings Account        | Savings Accounts | 1:1          | Bank of Serenity      | Earn competitive interest on your savings             | 650             | 2500.00  | 1000.00 |

## Relational Database

1. Menampilkan data dari tabel product dan productlines
   <br>

   ```sql
   SELECT pd.productName, pd.quantityInStock, pdl.productLine, pdl.textDescription
   FROM products pd
   LEFT JOIN productlines pdl
   	ON pd.productLine = pdl.productLine
   ```

   | customerName       | phone           | firstName | officeCode | addressLine1            | country   |
   | ------------------ | --------------- | --------- | ---------- | ----------------------- | --------- |
   | PT Nusantara Jaya  | +62 21 88888888 | Wulandari | BDG015     | Jl. Asia Afrika No. 111 | Indonesia |
   | PT Abadi Sentosa   | +62 22 77777777 | Permata   | MDN049     | Jl. Pemuda No. 55       | Indonesia |
   | CV Surya Kencana   | +62 31 66666666 | Lestari   | DPS091     | Jl. Raya Puputan No. 77 | Indonesia |
   | Toko Merpati Putih | +62 61 55555555 | Adi       | JKT001     | Jl. M.H. Thamrin No. 1  | Indonesia |
   | UD Bintang Timur   | +62 24 44444444 | Prasetyo  | SMR073     | Jl. Pandanaran No. 99   | Indonesia |
   | CV Bunga Indah     | +62 361 9999999 | Santoso   | SBY022     | Jl. Tunjungan No. 88    | Indonesia |

2. Menampilkan data dari tabel customer, employees, dan office
   <br>

   ```sql
   SELECT c.customerName, c.phone, e.firstName, e.officeCode, o.addressLine1, o.country
   FROM customers c
   	LEFT JOIN employees e
   		ON c.salesRepEmployeeNumber = e.employeeNumber
   	LEFT JOIN offices o
   		ON e.officeCode = o.officeCode
   ```

   | productName                       | quantityInStock | productLine      | textDescription                                          |
   | --------------------------------- | --------------- | ---------------- | -------------------------------------------------------- |
   | Cash Rewards Platinum Credit Card | 5               | Credit Cards     | Enjoy rewards and flexibility with our credit cards      |
   | 12-Month Certificate of Deposit   | 10              | Loans            | Finance your dreams with our personal and business loans |
   | Personal Loan                     | 100             | Loans            | Finance your dreams with our personal and business loans |
   | Home Equity Loan                  | 50              | Loans            | Finance your dreams with our personal and business loans |
   | Traditional IRA                   | 75              | Investments      | Build your wealth with our investment options            |
   | Money Market Account              | 500             | Investments      | Build your wealth with our investment options            |
   | High-Yield Savings Account        | 650             | Savings Accounts | Grow your savings with competitive interest rates        |
