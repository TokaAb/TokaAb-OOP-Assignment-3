# Part 01 — answers

---

## ShippingCostCalculator

- What was the problem?

that the ShippingCostCalculator used switch statements to calculate the shipping cost based on the shipping method, which is not easily extensible to add new shipping methods. If I want to add a new shipping method, I must change the code of the class and add a new case in the switch statement, this is not good because it violates the open/closed principle.
- What did you change?
- by replacing the switch statement with a strategy pattern. I created an 'IShippingCostStrategy' interface and separate strategy classes such as 'StandardShippingCostStrategy', 'ExpressShippingCostStrategy', and 'OvernightShippingCostStrategy'. The ShippingCostCalculator now uses a strategy to calculate the shipping cost, so I can add new shipping methods without changing the code of the class.

---

## OrderProcessor

- What was the problem?
- that the OrderProcessor used inheritance to handle different order types, which is not easily extensible to add new order types. If I want to add a new order type, I must change the code of the class and add a new method for the new order type, this is not good because it violates the open/closed principle.
- What did you change?
- by replacing the inheritance-based design with composition. I created an 'IOrderType' interface and separate order type classes such as 'StandardOrder', 'ExpressOrder', and 'InternationalOrder'. The OrderProcessor now uses an order type to process the order, so I can add new order types without changing the code of the class.

---

## Notifications

- What was the problem?  
there is many notification channels, and the code is not easily extensible to add new channels , if i want too add i must change the code of the class and add a new method for the new channel, this is not good because it violates the open/closed principle.

- What did you change?

  I replaced the inheritance-based design with composition. I created an 'INotificationChannel' interface and separate channel classes such as 'EmailChannel', 'SmsChannel', and 'WhatsAppChannel'. 'Notification' now uses a channel and handles the urgent and scheduled options, so I can combine them without creating a separate class .

---

## Proof

- New carrier file(s):
- New notification channel file(s):
- Existing classes left unchanged? (yes/no):
