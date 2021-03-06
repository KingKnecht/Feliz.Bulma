﻿namespace Feliz.Bulma.Checkradio

open Feliz
open Feliz.Bulma

module private ElementLiterals =
    let [<Literal>] ``is-checkradio`` = "is-checkradio"

type Checkradio =
    static member inline checkbox props =
        ElementBuilders.Input.propsWithType ElementLiterals.``is-checkradio`` prop.type'.checkbox props
    static member inline radio props =
        ElementBuilders.Input.propsWithType ElementLiterals.``is-checkradio`` prop.type'.radio props