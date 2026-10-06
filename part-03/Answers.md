# Part 03 — answers

---

## BlockedUsers

- Time complexity before:O(n^2)
- Time (ms) before: 30ms
- What did you change?
- Time complexity after: O(n)
- Time (ms) after: 2ms

---

## Students

- What was the problem?
created all 1,000,000 students and stored them in a list, even when the caller only needed the first few students.
- 

- What did you change?
I changed 'GetAllStudents()' to return (IEnumerable) and used 'yield return' .