Feature: StudentRepositoryInsert
	Insert Student in reposiroty

@mytag
Scenario: Add a student
	Given I have a new Student without id
	When I run the method Insert of Student Repository
	Then the student Repository should return Student Id
