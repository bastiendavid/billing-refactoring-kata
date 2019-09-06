# Billing refactoring kata

## Goals

The objective of this kata is to replace an old library by a new one (with a different contract).

To do so, you should try to use the [branch by abstraction approach](https://martinfowler.com/bliki/BranchByAbstraction.html)


## The kata

In this kata, we have a BillingService with a unique method invoice.

This service is currently sending our invoice data to our partner, eCorp.

However, management has decided to no longer work with eCorp, and we must now send our invoice data to a new partner, casaDePapel.

Our goal is to replace all the usages of GoodOldBillingSystem by BrandNewBillingSystem.

### Tips

First try to create an abstraction, and then replace the old code by the new one.

Your tests should always be green.

Perform baby steps.
