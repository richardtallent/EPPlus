# RT.Spreadsheet

RT.Spreadsheet is a fork of EPPlus 4.5.3.3, the final LGPL version of that library.

For support, new features, etc., **please support Jan's new commercial version of EPPlus**, hosted at https://github.com/EPPlusSoftware/EPPlus. You can also find a link there to the old (now frozen in time) verion of 4.5.3.3.

## Goals

I have no intention of competing with EPPlus, but I do have a need to maintain the LGPL version for my own projects, and better to do that here where others might benefit or chip in as well! My focus is on three areas:

- Bug fixes for bugs that impact my use cases (which are primarily large, text-heavy spreadsheets with macros, complex formulas, conditional formatting, and data validation, but _not_ with tables, pivot tables, charts, etc.).
- Performance improvements, particularly around memory allocation.
- Full .NET Core compatibility

I'll gladly accept PRs within that scope, or that are otherwise easy to review and limited in scope.

The source code formatting will differ significantly from EPPlus, since I make heavy use of newer C# language affordances and capabilities, and my preferred style for braces, etc. is a bit different. I'm currently targeting only fairly recent .NET Standard and Framework versions.

## The Name

The project has been renamed to avoid any potential for confusion with EPPlus.

## Trajectory

This is very much a back-burner project for me, I have a number of other open-source projects I work on in my spare time, along with hobbies, family, etc. Please file issues only if you have a specific, reproducible bug, and, ideally, a fix for it. I won't be able to reply to issues related to general use of the library, etc. Since this is a fork of EPPlus, any example code you find for it should work for this library, just with the namespace changed.

## License

The project is licensed under the GNU Library General Public License (LGPL).

## Change Log

2020-05-28 Initial fork; code formatting; fix bug in VAlign. README updated.
2020-06-12 Renamed, updated default branch name
