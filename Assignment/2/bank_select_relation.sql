SELECT * FROM `customers`;
SELECT * FROM `offices`;
SELECT * FROM `orderdetails`;
SELECT * FROM `payments`;
SELECT * FROM `productlines`;
SELECT * FROM `products`;


SELECT pd.productName, pd.quantityInStock, pdl.productLine, pdl.textDescription 
FROM products pd  
LEFT JOIN productlines pdl
	ON pd.productLine = pdl.productLine;
	
SELECT c.customerName, c.phone, e.firstName, e.officeCode, o.addressLine1, o.country 
FROM customers c 
	LEFT JOIN employees e 
		ON c.salesRepEmployeeNumber = e.employeeNumber
	LEFT JOIN offices o 
		ON e.officeCode = o.officeCode;