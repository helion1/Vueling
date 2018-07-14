using FileServer.Common.Model;
using FileServer.Infrastructure.Respository.Repositories;
using FluentAssertions;
using System;
using TechTalk.SpecFlow;

namespace FileServer.BehaviorTest.FileServer.IntegrationTest
{
    [Binding]
    public class StudentRepositoryInsertSteps{
        protected StudentRepository repository = new StudentRepository();
        protected Student student;


        [Given(@"I have a new Student without id")]
        public void GivenIHaveANewStudentWithoutId()
        {
            student = new Student(new DateTime(1990, 6, 22));
        }
        
        [When(@"I run the method Insert of Student Repository")]
        public void WhenIRunTheMethodInsertOfStudentRepository()
        {
            repository.Insert(student);
        }
        
        [Then(@"the student Repository should return Student Id")]
        public void ThenTheStudentRepositoryShouldReturnStudentId()
        {
            student.Id.Should().Be(1);
            student.Age.Should().Be(28);
        }
    }
}
