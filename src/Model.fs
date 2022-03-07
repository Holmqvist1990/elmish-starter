module Model

type Deferred<'t> =
    | HasNotStartedYet
    | InProgress
    | Resolved of 't

type DeferredResult<'t> = Deferred<Result<'t, string>>

type AsyncStatus<'t> =
    | Started
    | Finished of 't

type State = unit

type Msg = unit
