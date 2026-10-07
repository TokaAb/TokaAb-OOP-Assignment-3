# Part 02 — answers

---



## Reports

- What was the problem?
exports had duplicate entries in the report, which caused confusion and inaccuracies in the data presented.

- What did you change?

I created an abstract 'ReportExporter' class that contains the common export steps. I made 'Format' abstract so each exporter can implement its own formatting. 
- Why did you choose that approach?
-  because the three exporters follow the same steps in the same order, but the formatting step is different. An abstract class is a good fit because it allows us to share the common implementation while letting each exporter customize 'Format'.

---

## Enrollment

- What was the problem?
'Program.cs' created and called the four services directly and had to know the correct order of the enrollment steps
- What did you change?
I created an 'EnrollmentFacade' class that encapsulates the enrollment logic and hides the details of the four services.
- Why did you choose that approach?
Because it reduces the complexity of the 'Program.cs' file and makes the code more maintainable and testable.