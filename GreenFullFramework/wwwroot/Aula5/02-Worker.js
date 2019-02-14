if (typeof (Worker) !== "undefined") {
    // Yes! Web worker support!

    let i = 0;

    const timedCount = (counter) => {
        counter += 1;

        postMessage(counter);

        setTimeout(timedCount, 500, counter);
    };

    i = timedCount(i);
} else {
    // Sorry! No Web Worker support..
}