# Manual verification

Run against fictional data in a disposable local database. The source review is not a Windows build or MySQL integration test.

## Setup

- Record the commit, Windows version, Visual Studio version, MySQL version, and MySql.Data version.
- Clone to a new folder and follow README.md without relying on files outside the repository.
- Restore dependencies and rebuild. Confirm no Downloads paths remain.
- Set the user variables, log in with admin, test Enter, incorrect login, Logout, and login again.
- If seed.sql was run exactly once in an empty demo database, initial counts are total assets 1, available assets 1, active missions 0, maintenance due 1.

## Regression scenarios

| Action | Expected |
| --- | --- |
| Save blank station/crew/asset fields required by README | Validation message; no insert |
| Save a mission or maintenance record without an asset/status | Validation message; no insert |
| Type/paste an apostrophe or Unicode in a name | Saves correctly within the column's length |
| Select an existing record and press Save twice | No duplicate; tells user to use Update or New |
| Select a mission with assigned crew, press New, save another mission | New mission has an empty crew grid |
| Assign same person twice with different roles | One assignment with updated role |
| Set mission end date before start date | Rejected |
| Set maintenance next due date before service date | Rejected |
| Leave either optional date unchecked | NULL stored; reopening preserves unchecked state |
| Cancel due maintenance | That asset leaves due count if it has no other qualifying record |
| Add two outstanding due records for one asset | Due counter counts that asset once |
| Mark due work Completed | Removed from due count unless other qualifying work exists |
| Due date tomorrow | Excluded from due count |
| Select New, then Update/Delete | No database change; selection/validation message |
| Cancel delete confirmation | Data and assignments remain |
| Delete a mission/crew member | Its assignments removed; unrelated records preserved |
| Delete referenced station/asset in demo schema | Clear related-record warning; no deletion |
| Close and restart app | Saved data and relationships persist |
| Open each form and use Back once | Returns to dashboard once |
| Stop local MySQL, then activate dashboard | N/A counters and an error; no recursive popup loop |
| Restore local MySQL and reactivate dashboard | Counts refresh |
| Configure cg_app password containing a semicolon | Connects correctly through connection-string builder |

## Transaction failure test for a technical reviewer

On the disposable InnoDB demo database only, arrange for deletion of a selected mission or crew member to fail AFTER assignment deletion is attempted (for example, temporarily add a test BEFORE DELETE trigger on that parent table that signals an error). Execute the delete through the application. Query both the parent and mission_crew afterward: both must be unchanged. Remove the temporary trigger and repeat a successful delete.

Database setup/trigger changes require an administrator; the app account should remain limited to SELECT, INSERT, UPDATE, and DELETE. Do not perform this failure injection on a real database.

## Report format

For each issue: steps, expected result, actual result, screenshot/error message with secrets omitted, and the record IDs involved. Record the date and which tests actually passed. A source review alone must not be marked as a passing runtime test.
