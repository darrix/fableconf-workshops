module Logger

    open Fable.Import.JS

    let inline error msg = console.error msg

    let inline log msg = console.log msg

    let inline debug info = printfn "[Debug] %A" info

    let inline debugfn fn info = console.log("[Debug] " + sprintf fn info)
