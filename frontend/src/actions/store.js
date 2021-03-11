import { createStore, applyMidddleware, compose } from "redux";
import thunk from "thunk-redux";

export const store = createStore(
    {},
    compose(
        applyMidddleware(thunk)
    )
)