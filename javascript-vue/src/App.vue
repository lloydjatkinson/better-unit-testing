<template>
    <div
        id="app">
        <div class="flex flex-wrap content-center justify-center w-screen h-screen ">
            <TrafficLight />
        </div>
    </div>
</template>

<script>
import TrafficLight from './components/TrafficLight';

export default {
    name: 'App',
    components: {
        TrafficLight,
    },
};
</script>

<style>
body {
    background-color: #EDF2F7
}
</style>