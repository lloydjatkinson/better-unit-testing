<template>
    <span
        class="w-16 h-16 my-3 border-2 border-black rounded-full"
        :data-on="on"
        :data-colour="colour"
        :class="colourStyle" />
</template>

<script>
import { Red, RedYellow, Green } from './traffic-light-states';

export default {
    name: 'TrafficLightBulb',
    props: {
        colour: {
            type: String,
            required: true,
        },
        on: {
            type: Boolean,
            required: true,
        },
    },
    computed: {
        colourStyle () {
            if (this.on) {
                return {
                    'bg-red-on': this.colour === Red,
                    'bg-yellow-on': this.colour === RedYellow,
                    'bg-green-on': this.colour === Green,
                };
            }

            return {
                'bg-red-off': this.colour === Red,
                'bg-yellow-off': this.colour === RedYellow,
                'bg-green-off': this.colour === Green,
            };
        },
    },
};
</script>