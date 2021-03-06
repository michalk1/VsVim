﻿#light
namespace Vim.Interpreter
open EditorUtils
open Vim
open Microsoft.VisualStudio.Text
open System.Collections.Generic

/// Engine which interprets Vim commands and expressions
[<Sealed>]
[<Class>]
type Interpreter =

    new : vimBuffer : IVimBuffer * commonOperations : ICommonOperations * foldManager : IFoldManager * fileSystem : IFileSystem * bufferTrackingService : IBufferTrackingService -> Interpreter

    /// Get the ITextSnapshotLine for the provided LineSpecifier if it's 
    /// applicable
    member GetLine : lineSpecifier : LineSpecifier -> ITextSnapshotLine option

    /// Get the specified LineRange in the IVimBuffer
    member GetLineRange : lineRange : LineRangeSpecifier -> SnapshotLineRange option

    /// Run the LineCommand
    member RunLineCommand : lineCommand : LineCommand -> RunResult

    /// Run the Expression
    member RunExpression : expression : Expression -> VariableValue

