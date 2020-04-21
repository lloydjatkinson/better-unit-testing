<template>
    <button
        class="px-4 py-2 font-semibold text-white bg-indigo-600 rounded focus:outline-none hover:bg-indigo-700 active:bg-indigo-800"
        v-bind="$attrs"
        @click="value => $emit('click', value)">
        <slot />
    </button>
</template>

<script>
export default {
    name: 'TrafficLightButton',
};
</script>