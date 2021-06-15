# Dell Technical Challenges

## Technical Challenge presentation:
* There are 6 projects in the DellChallenge solution and each one has a series of problems that need to be solved;
* The first three projects (_A, B, C_) are aiming for coding practices and standards;
* Project _D1_ aims to verify the backend skills in developing Web APIs;
  * _hint_: use `/swagger` endpoint;
* Placeholder _DellChallenge.D2.React_ aims to verify skills in using React;
* Placeholder _DellChallenge.E.RabbitMQ_ aims to verify skills in using RabbitMQ;
* Please try and solve as much as possible of the challenges in their order;
* There is no need for connecting to a database, feel free to use the already implemented in memory one;

## There are 6 problems that need to be solved:
1. Project: __DellChallenge.A__
    * Please idenfity the following class _Program.cs_, then state and explain the comment in main method;
    
2. Project: __DellChallenge.B__
    * Please idenfity the following class _Program.cs_, then state and explain the comment in main method;
    
3. Project: __DellChallenge.C__
    * Please idenfity the following class _Program.cs_, then state and explain the comment in main method;
    
4. Project: __DellChallenge.D1.Api__
    * Change `ProductsController`:
        * Implement Get(id) method;
        * Implement Delete method;
        * Implement Put method;
    
5. Project: __DellChallenge.D2.React__
    * Create a SPA using [React](https://reactjs.org/) that consumes __DellChallenge.D1.Api__'s resources;

6. Project: __DellChallenge.E.RabbitMQ__
    * Create a project using [.NET/C# RabbitMQ Client Library](https://www.rabbitmq.com/dotnet.html)
    * Must have the following behavior

```
                                        sms       +------------+     +--------------+
                                      +---------->|Sms Queue   +---->|Sms Consumer  |
                                      |           +------------+     +--------------+
                                      |
 +---------+  message   +---------+   | email     +------------+     +--------------+
 |Producer +----------->|Exchange +---+---------->|Email Queue +---->|Email Consumer|
 +---------+            +---------+   |           +------------+     +--------------+
                                      |
                                      | *(all)    +------------+     +--------------+
                                      +---------->|Audit Queue +---->|Audit Consumer|
                                                  +------------+     +--------------+
 ```

# NOTES
* __Provided solution must compile;__
* __Please provide instructions for running project DellChallenge.D2.React;__
* __Please provide instructions for running project DellChallenge.E.RabbitMQ;__
