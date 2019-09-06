package org.training.billing


enum class Currency private constructor(var symbol: String) {
    EURO("€"),
    DOLLAR("$")
}
