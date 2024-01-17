# Payment API Documentation

This document outlines the RESTful API endpoints for managing payment data.

Base URL: `/api/payment`

| Endpoint | HTTP Method	Description | Description |
|----------|-------------------------|-------------|
| /        | GET                     | Retrieves a list of all payment data.            |
| /{id}    | GET                     | Retrieves a specific payment record by its ID.            |
| /        | POST                    | Creates a new payment record.            |
| /{id}    | PUT                     | Updates an existing payment record.            |
| /{id}    | DELETE                  | Deletes an existing payment record.            |

Example Request Body (POST, PUT):

```JSON
{
  "PaymentDetailId": int,
  "CardNumber": DataType.CreditCard,
  "CardOwnerName": string,
  "ExpirationDate": yyyy-MM-dd,
  "SecurityCode": string
}
```

Response:

```JSON
{
  "PaymentDetailId": 1,
  "CardNumber": "1234567890123456",
  "CardOwnerName": "John Doe",
  "ExpirationDate": "2025-12-31",
  "SecurityCode": "123"
}
```