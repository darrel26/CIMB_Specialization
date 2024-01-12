USE bank;

-- productlines table
INSERT INTO productlines (productLineID, productLine, textDescription, htmlDescription, image)
VALUES
    (1, 'Checking Accounts', 'Manage your everyday spending with ease', 'checking.html', 'checking.jpg'),
    (2, 'Savings Accounts', 'Grow your savings with competitive interest rates', 'savings.html', 'savings.jpg'),
    (3, 'Credit Cards', 'Enjoy rewards and flexibility with our credit cards', 'creditcards.html', 'creditcards.jpg'),
    (4, 'Loans', 'Finance your dreams with our personal and business loans', 'loans.html', 'loans.jpg'),
    (5, 'Investments', 'Build your wealth with our investment options', 'investments.html', 'investments.jpg'),
    (6, 'Retirement Planning', 'Secure your future with our retirement planning solutions', 'retirement.html', 'retirement.jpg'),
    (7, 'Insurance', 'Protect yourself and your loved ones with our insurance products', 'insurance.html', 'insurance.jpg');


-- products table
INSERT INTO products (productID, productCode, productName, productLine, productScale, productVendor, productDescription)
VALUES
    (1, 'SA001', 'High-Yield Savings Account', 'Savings Accounts', '1:1', 'Bank of Serenity', 'Earn competitive interest on your savings'),
    (2, 'CC015', 'Cash Rewards Platinum Credit Card', 'Credit Cards', '1:1', 'Trustworthy Financial', 'Earn 5% cash back on everyday purchases'),
    (3, 'CL022', 'Personal Loan', 'Loans', '1:1', 'Reliable Bank', 'Consolidate debt or finance a major purchase'),
    (4, 'MM049', 'Money Market Account', 'Investments', '1:1', 'Secure Savings Bank', 'Access your funds while earning higher interest'),
    (5, 'CD073', '12-Month Certificate of Deposit', 'Loans', '1:1', 'Steadfast Investments', 'Lock in a guaranteed interest rate'),
    (6, 'HE091', 'Home Equity Loan', 'Loans', '1:1', 'Homestead Financial', 'Tap into the equity of your home for cash'),
    (7, 'IRA115', 'Traditional IRA', 'Investments', '1:1', 'FutureWise Retirement', 'Save for retirement with tax-deductible contributions');

   
-- orders table
INSERT INTO orders (orderNumber, orderDate, requiredDate, shippedDate, status, comments, customerNumber)
VALUES=
    (1, '2024-01-12', '2024-01-19', '2024-01-17', 'Pending', 'Awaiting customer confirmation for items', 101),
    (2, '2024-01-12', '2024-01-26', '2024-01-22', 'Processed', 'Items are being prepared for shipment', 102),
    (3, '2024-01-12', '2024-02-02', '2024-01-27', 'Shipped', 'Order has been dispatched', 103),
    (4, '2024-01-12', '2024-02-09', '2024-02-01', 'Pending', 'Awaiting payment processing', 104),
    (5, '2024-01-12', '2024-02-16', '2024-02-06', 'Processed', 'Items are undergoing quality checks', 105),
    (6, '2024-01-12', '2024-02-23', '2024-02-11', 'Pending', 'Awaiting inventory availability', 106),
    (7, '2024-01-12', '2024-03-01', '2024-02-16', 'Shipped', 'Tracking number: 1Z234567890', 107);
   
-- offices table
INSERT INTO offices (officeCode, city, phone, addressLine1, addressLine2, state, country, postalCode, territory)
VALUES
    ('JKT001', 'Jakarta', '+62 21 5555555', 'Jl. M.H. Thamrin No. 1', 'Central Jakarta', 'DKI Jakarta', 'Indonesia', '10350', 'Jakarta Raya'),
    ('BDG015', 'Bandung', '+62 22 4444444', 'Jl. Asia Afrika No. 111', 'Bandung City Center', 'West Java', 'Indonesia', '40111', 'Priangan'),
    ('SBY022', 'Surabaya', '+62 31 3333333', 'Jl. Tunjungan No. 88', 'Genteng', 'East Java', 'Indonesia', '60275', 'East Java'),
    ('MDN049', 'Medan', '+62 61 2222222', 'Jl. Pemuda No. 55', 'Medan Maimun', 'North Sumatra', 'Indonesia', '20151', 'Sumatra Utara'),
    ('SMR073', 'Semarang', '+62 24 1111111', 'Jl. Pandanaran No. 99', 'Pekunden', 'Central Java', 'Indonesia', '50134', 'Central Java'),
    ('DPS091', 'Denpasar', '+62 361 8888888', 'Jl. Raya Puputan No. 77', 'Renon', 'Bali', 'Indonesia', '80234', 'Bali'),
    ('MKS115', 'Makassar', '+62 411 7777777', 'Jl. Jenderal Sudirman No. 66', 'Maricaya Baru', 'South Sulawesi', 'Indonesia', '90145', 'Sulawesi Selatan');
   
-- employees table
INSERT INTO employees (employeeNumber, lastName, firstName, extension, email, officeCode, reportsTo, jobTitle)
VALUES
    (1001, 'Prabowo', 'Adi', '5432', 'adi.prabowo@bank.com', 'JKT001', NULL, 'Branch Manager'),
    (1002, 'Karina', 'Wulandari', '6789', 'karina.wulandari@bank.com', 'BDG015', 1001, 'Loan Officer'),
    (1003, 'Budi', 'Santoso', '1234', 'budi.santoso@bank.com', 'SBY022', 1001, 'Customer Service Representative'),
    (1004, 'Indah', 'Permata', '5678', 'indah.permata@bank.com', 'MDN049', 1002, 'Financial Analyst'),
    (1005, 'Eko', 'Prasetyo', '9012', 'eko.prasetyo@bank.com', 'SMR073', 1004, 'Accountant'),
    (1006, 'Ayu', 'Lestari', '3456', 'ayu.lestari@bank.com', 'DPS091', 1003, 'Investment Advisor'),
    (1007, 'Rahmat', 'Hidayat', '7890', 'rahmat.hidayat@bank.com', 'MKS115', 1005, 'Teller');
   
-- customers table
INSERT INTO customers (customerNumber, customerName, contactLastName, contactFirstName, phone, addressLine1, city, state, postalCode, country, salesRepEmployeeNumber, creditLimit)
VALUES
    (12001, 'PT Nusantara Jaya', 'Wijaya', 'Agung', '+62 21 88888888', 'Jl. Merdeka Raya No. 10', 'Jakarta', 'JK', '10450', 'Indonesia', 1002, 500000.00),
    (12002, 'PT Abadi Sentosa', 'Susilowati', 'Ratna', '+62 22 77777777', 'Jl. Braga No. 25', 'Bandung', 'JB', '40114', 'Indonesia', 1004, 250000.00),
    (12003, 'CV Surya Kencana', 'Putra', 'Bambang', '+62 31 66666666', 'Jl. Panglima Sudirman No. 50', 'Surabaya', 'JI', '60251', 'Indonesia', 1006, 100000.00),
    (12004, 'Toko Merpati Putih', 'Prasetyo', 'Eko', '+62 61 55555555', 'Jl. Gatot Subroto No. 12', 'Medan', 'SU', '20153', 'Indonesia', 1001, 75000.00),
    (12005, 'UD Bintang Timur', 'Lestari', 'Ayu', '+62 24 44444444', 'Jl. Pahlawan No. 8', 'Semarang', 'JT', '50135', 'Indonesia', 1005, 35000.00),
    (12006, 'CV Bunga Indah', 'Hidayat', 'Rahmat', '+62 361 9999999', 'Jl. Kuta Raya No. 15', 'Denpasar', 'BA', '80361', 'Indonesia', 1003, 150000.00);

-- payments table
INSERT INTO payments (`customerNumber`, `checkNumber`, `paymentDate`, `amount`) 
VALUES 
		(12002, 'CK-12221', '2024-01-05', '1121.40'),
		(12003, 'CK-12121', '2024-01-05', '4561.61'),
		(12004, 'CK-12991', '2024-01-02', '7121.35'),
		(12005, 'CK-12091', '2023-07-04', '3229.12');

-- orders table
INSERT INTO orders (orderNumber, orderDate, requiredDate, shippedDate, status, comments, customerNumber)
VALUES
    (10001, '2023-11-02', '2023-11-15', NULL, 'In Process', "Processed in Sorting Center", 12001),
    (10002, '2023-11-03', '2023-11-20', NULL, 'Pending', "Pending due to High traffic", 12002),
    (10003, '2023-11-04', '2023-11-10', '2023-11-05', 'Shipped', "Shipped to the address", 12003),
    (10004, '2023-11-05', '2023-11-22', NULL, 'On Hold', NULL, 12004),
    (10005, '2023-11-06', '2023-11-12', '2023-11-08', 'Completed', NULL, 12005),
    (10006, '2023-11-07', '2023-11-18', NULL, 'Cancelled', "Cancelled due to Out of Stock", 12006);
   
-- orderdetails table
INSERT INTO orderdetails (orderLineNumber, orderNumber, productCode, quantityOrdered, priceEach)
VALUES
    (1, 10001, 'SA001', 1, 43.65),
    (2, 10002, 'MM049', 5, 78.08),
    (3, 10003, 'HE091', 3, 93.75),
    (4, 10004, 'CL022', 3, 89.82),
    (5, 10005, 'SA001', 2, 81.07),
    (6, 10006, 'SA001', 2, 70.14),
    (7, 10006, 'MM049', 2, 71.76);






