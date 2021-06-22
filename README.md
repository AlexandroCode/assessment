# RIMSA
Code Assessment

----
## Timeline
Please send completed project within 4 days. Let us know if you need more time.

## Version Control
Use git

## Language
C# or Java

## Objective
Build a `WorkOrders` API with two kind of action items preventive and corrective; that demonstrates your ability to design an easy to use, well-documented RESTful API. And your ability to explain your design decisions and the considerations you made.

## Instructions

### Build a RESTful Messaging API that includes (but is not necessarily limited to) the following resources:
* Technicians
* WorkOrders
* Retainers
* Tickets

### The RESTful API should at least allow you to:
* Create users (with a username)
* List users
* Create new ticket assigned to technician - should be able to have multiple tickets
* List all tasks as work orders (retainers and tickets) by technician and order by date desc
* Able to mark as done 
* View all task done and pending to be done
* Routes should be organized logically
* Models should include necessary associations
* There should be index, show, create and update routes for all resources
* Please use a benchmarking tool to examine the performance of your routes. For example https://github.com/wg/wrk
* Database tables should include a few attributes besides id and timestamps (for example customer, or task description, whatever you like)
* API should accept and respond with JSON objects, with reasonable HTTP headers
* It should be backed by some kind of persistent data store
* Please consider performance and scalability when designing your API and explain your design decisions in your comments or documentation.
* Send instructions on how to run the app locally so that we can run in and check it out

### Please include one of the following in order to make it easy for us to test your API:
* API Documentation with sample request and response payload and allowable parameters
* Basic UI that uses the routes you have created (can be bootstrapped and minimalistic)
* Postman Sample Requests or similar

## Bonus Points
* Appropriate use of task management tool
* Clean architecture
* Appropriate unit tests for bounderies implementations
* Some kind of authentication mechanism
* Some kind of API documentation with sample payload and any params that are required or optional
* More sophisticated and fleshed out UI if you like
* Deployed at cloud service
