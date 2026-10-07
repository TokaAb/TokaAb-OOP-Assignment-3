What is IReadOnlyDictionary<TKey,TValue>?

interface like dictionary that provides read-only access to a collection of key-value pairs.

what is SortedDictionary?
dictionary that maintains its elements in sorted order based on the keys.

 how is IReadOnlyDictionary different from Dictionary?
 
 IReadOnlyDictionary<TKey, TValue> is an interface that provides read-only access to a collection of key-value pairs. It allows you to retrieve values based on keys but does not allow modification of the collection (no adding, removing, or updating elements).

 Why would a public method return IReadOnlyDictionary instead of Dictionary?

 because  IReadOnlyDictionary allows caller to just read the data without the ability to modify it.

 How is SortedDictionary different from Dictionary?
 because SortedDictionary<TKey, TValue> maintains its elements in sorted order based on the keys, while Dictionary<TKey, TValue> does not guarantee any specific order of the elements.

 When would you choose it?
 SortedDictionary -> when i want to maintain the elements in a sorted order based on the keys.
 IReadOnlyDictionary<TKey,TValue> -> when you want to return dictionary data to a caller but don't want the caller to modify it.



S1 Find a student by national ID — thousands of times a day.        dictionary    
S2 Keep the tags of a course. The same tag must never be stored twice.                   HashSet
S3 Keep a student's grades in the order they were entered. The same grade can appear more than once.     List

S4 A public method returns the course price list. Callers can read prices but must not add or change any.       IReadOnlyDictionary
S5 A timetable keyed by session start time. Sessions are added at any moment, and it must always print in 
time order.                                                                                                      sortedDictionary
S6 A method returns results that the caller only loops over once — and may stop early                           IEnumerable