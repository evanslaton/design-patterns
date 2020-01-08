# The Proxy Pattern
Provides a surrogate or placeholder for another object to control access to it.

## Local Representative
An object that you can call local methods on and have them forwarded on to a remote object.

## Proxies
* Remote Proxy - controls access to a remote object
* Virtual Proxy - controls access to a resource that is expensive to create
  * Caching Proxy - maintains a cache of previously created objects and returns cached objects when a request is made
* Protection Proxy - controls access to a resource based on access rights