Feature: BookReservation
Reserving a book

    @mytag
    Scenario: Succesfully reserving a book
        Given the book entitled Harry Potter Philosophers Stone is available
        When a reservation request is sent
        Then the reservation is successful

    @mytag
    Scenario: Book is out of stock
        Given the book entitled Harry Potter Goblet of Fire is unavailable
        When a reservation request is sent
        Then the reservation is unsuccessful

    @mytag
    Scenario: Invalid reservation request
        Given ISBN of <ISBN>
        And Membership Number of <MembershipNumber>
        When a reservation request is sent
        Then the reservation is unsuccessful
        And error code is <ErrorCode>

    Examples:
      | ISBN    | MembershipNumber | ErrorCode                   |
      |         |                  | InvalidISBN,InvalidMemberNo |
      | 123-123 |                  | InvalidMemberNo             |
      |         | OC230884         | InvalidISBN                 |