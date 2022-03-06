[<RequireQualifiedAccess>]
module Async

let map f a = async {
    let! b = a
    let v = f b
    return v
}
