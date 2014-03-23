/* 
	In this database, the filepath  acts as the primary key, even though 
that is not explicitly stated in the database (this shouldn't be a problem).

The sync column stores an int (as SQLite doesn't recognize Boolean values)
so we'll just use 1 and 0 for true and false as integers.	
*/


/* To obtain all filepaths with tag1 use: */
SELECT filepath
FROM FileTags
WHERE tags LIKE "%tag1%"

/* To obtain all filepaths with both tag1 and tag2 use: */
SELECT filepath
FROM FileTags
WHERE tags LIKE "%tag1%"
AND tags LIKE "%tag2%"

/* To obtain all filepaths with either tag1 or tag2 use: */
SELECT filepath
FROM FileTags
WHERE tags LIKE "%tag1%"
OR tags LIKE "%tag2%"

/* To add filepath, file1, with tags, tag1, tag2, and tag3, to the database use: */
INSERT INTO FileTags(filepath, tags)
VALUES('filepath1', 'tag1, tag2, tag3')

/* To remove filepath, file1, from the database use: */
DELETE FROM FileTags
WHERE filepath = 'file1'

/* 
Removing a tag from a file path will be a little more difficult than a straight up SQL query. 
We can get the tags with:

SELECT tags
FROM FileTags
WHERE filepath = 'file1'

and then use C# to parse the string of tags, find and remove the tag, and then update the tags with:

UPDATE FileTags
SET tags = 'tags'
WHERE filepath = 'file1'
*/