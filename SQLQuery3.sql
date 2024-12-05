CREATE TABLE Questions (
    QuestionID INT PRIMARY KEY IDENTITY(1,1),
    QuizID INT FOREIGN KEY REFERENCES Quizzes(QuizID),
    QuestionText NVARCHAR(1000),
    AnswerA NVARCHAR(200),
    AnswerB NVARCHAR(200),
    AnswerC NVARCHAR(200),
    AnswerD NVARCHAR(200),
    CorrectAnswer CHAR(1)
);
