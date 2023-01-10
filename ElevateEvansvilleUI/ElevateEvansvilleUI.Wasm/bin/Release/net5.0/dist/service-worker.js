import { config } from "/package_aa7e15977f6a7d6d4f5d01fb2b33f0f125040dc9//uno-config.js";

console.debug("[ServiceWorker] Initializing");

self.addEventListener('install', function (e) {
    console.debug('[ServiceWorker] Installing offline worker');
    e.waitUntil(
        caches.open('package_aa7e15977f6a7d6d4f5d01fb2b33f0f125040dc9').then(function (cache) {
            console.debug('[ServiceWorker] Caching app binaries and content');
            return cache.addAll(config.offline_files);
        })
    );
});

self.addEventListener('activate', event => {
    event.waitUntil(self.clients.claim());
});

self.addEventListener('fetch', event => {
    event.respondWith(async function () {
        try {
            // Network first mode to get fresh content every time, then fallback to
            // cache content if needed.
            return await fetch(event.request);
        } catch (err) {
            return caches.match(event.request).then(response => {
                return response || fetch(event.request);
            });
        }
    }());
});


// managed