-- What is the same between StudentStore and CourseStore?
- Both use a List to store their objects.
- Both have an Add method.
- Both have a GetById method.
- Both have a GetAll method.
- Both have a Remove method.





 What is different?
 The main difference is the type of object they store.

- StudentStore stores Student objects.
- CourseStore stores Course objects.
The code is very similar, so using two separate store classes causes duplicated code.
This is why we can use a generic Store<T> instead.

//From step 7
The following line must NOT compile:

// Store<string> stringStore = new Store<string>();

Store<T> has the constraint:

where T : IHasId

This means that T must implement IHasId.

Student and Course implement IHasId, so they can be used with Store<T>.

string does not implement IHasId, so Store<string> does not satisfy the generic constraint and should not compile.